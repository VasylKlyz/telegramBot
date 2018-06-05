using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeleSharp.TL;
using TeleSharp.TL.Messages;
using TLSharp.Core;
namespace bot_crypto
{
    public class Channel
    {

        public TLInputPeerChannel channel { get; set; }
        public int prevIds { get; set; }
        public string name { get; set; }
        public Channel(TLInputPeerChannel c, int p,string s)
        {
            channel = c;
            prevIds = p;
            name = s;
        }

    }
    /*
     Добрый день, вас привествует бот крипто сообщества "Empire" тут вы можете озанкомится с разными каналами для рекомендаций по сделкам или покупкам разной криптовалюты.
оплатив 0.1 BTC вы можете получить полный доступ ко всем каналам , список которых вы можете увидеть в личном кабинете. Доступ дается на 3 месяца с момента оплаты.
Это бот сообщества "Empire" с его помощью вы можете получать мгновенный доступ к приватной информации, той которою вы выберете, не нужные вам каналы не будут вас беспокоить.

         */
    class StartBot
    {
        TlegrammSendMessagesToUsersByBot bot;
        TelegramClient client;
        TeleSharp.TL.Messages.TLDialogsSlice dialogs;
        List<Channel> channels;
        public StartBot(string[] ch)
        {
            client = new TelegramClient(230749, "16453a5b23d1217261c389337c3acd70");//243010  0e3363e67ec1b0c3afea9e0a8b2adea9
            channels = new List<Channel>();
            bot = new TlegrammSendMessagesToUsersByBot();
            GetPeerChannel(ch);
        }
        private async void GetPeerChannel(string[] ChannelsName)
        {
            await client.ConnectAsync();
            #region auth by pass
            //var hash = await client.SendCodeRequestAsync("+380954694118");
            //var code = "";
            //TeleSharp.TL.TLUser user;
            //try
            //{
            //    user = await client.MakeAuthAsync("+380954694118", hash, code);
            //}
            //catch (CloudPasswordNeededException ex)
            //{
            //    var password = await client.GetPasswordSetting();
            //    var password_str = "blackwhales";

            //    user = await client.MakeAuthWithPasswordAsync(password, password_str);
            //}
            #endregion
            dialogs = (TeleSharp.TL.Messages.TLDialogsSlice)await client.GetUserDialogsAsync();
            nullDilog: if (dialogs == null)
            {
                goto nullDilog;
            }
            foreach (var item in ChannelsName)
            {
                var channel = dialogs.Chats.OfType<TLChannel>().Cast<TLChannel>().FirstOrDefault(c => c.Title == item);
                channels.Add(new Channel(new TLInputPeerChannel() { ChannelId = channel.Id, AccessHash = (long)channel.AccessHash }, 0,item));//0- it is must be previous value
            }
            first_channels();
            await Task.Run(() => this.getMessages());
        }
        public async void first_channels()
        {
            foreach (var item in channels)
            {
                TLChannelMessages result = await client.SendRequestAsync<TLChannelMessages>
                         (new TLRequestGetHistory()
                         {
                             Peer = item.channel,
                             Limit = 1,
                             AddOffset = 0,
                             OffsetId = 0,
                         });
                foreach (var items in result.Messages)
                {
                    TLMessage tLMessage = items as TLMessage;
                    item.prevIds = tLMessage.Id;
                }
            }
        }
        async private void getMessages()
        {
            while (true)
            {
                foreach (var channelPeer in channels)
                {
                    //TODO:реализовать полную последовательность получения сообщений со всеми внутренними файлами
                    Thread.Sleep(3000);
                    TLChannelMessages result = await client.SendRequestAsync<TLChannelMessages>
                          (new TLRequestGetHistory()
                          {
                              Peer = channelPeer.channel,
                              Limit = 30,
                              AddOffset = 0,
                              OffsetId = 0,
                              MinId = channelPeer.prevIds
                          });
                    var messages = result.Messages;
                    foreach (var item in messages.Reverse())
                    {
                        if (item is TLMessage)
                        {
                            TLMessage message = item as TLMessage;
                            //TODO: make korrect if to media content and take new photo if it is
                            var sizes = result.Messages
                                  .OfType<TLMessage>()
                               .Where(m => m.Media != null)
                               .Select(m => m.Media)
                               .OfType<TLMessageMediaPhoto>()
                               .Select(mp => mp.Photo)
                               .OfType<TLPhoto>()
                               .Where(sc => sc.Id != 1)
                               .Select(sd => sd.Sizes)
                               .FirstOrDefault();
                            if (sizes != null)
                            {
                                var photo = sizes
                                .OfType<TLPhotoSize>()
                                .Select(s => s.Location)
                                .OfType<TLFileLocation>()
                                .LastOrDefault();
                                var size = sizes
                                    .OfType<TLPhotoSize>()
                                    .LastOrDefault();
                                if (sizes != null && size != null && photo != null)
                                {
                                    var resFile = await client.GetFile(
                                    new TLInputFileLocation()
                                    {
                                        LocalId = photo.LocalId,
                                        Secret = photo.Secret,
                                        VolumeId = photo.VolumeId
                                    }, (int)Math.Pow(2, Math.Ceiling(Math.Log(size.Size, 2))));
                                    bot.sendMessage(message, channelPeer.name,resFile);
                                    channelPeer.prevIds++;
                                }
                            }
                           else if (message != null)
                            {
                                bot.sendMessage(message,channelPeer.name);
                                channelPeer.prevIds++;
                            }
                        }
                        if (item is TLMessageService)
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}