using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using System.IO;
using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading;
namespace bot_crypto
{
    public class TlegrammSendMessagesToUsersByBot
    {
        //TODO: получать доступ к модели базы данных для реализации всех проверок
        List<string> userId = new List<string>() { "281998026" /*, "493513951" */};
        TelegramBotClient Bot;
        public TlegrammSendMessagesToUsersByBot()
        {
            //@crypto_sklad_empire_bot
            Bot = new TelegramBotClient("586914291:AAGGTaA-lXEzNr_niBWvBRVH_bF4aE26v0E");//"556610527:AAEPwqrf-AZo6QpFbLil7mMfAcEQmNaj_V4
            Bot.SetWebhookAsync("");
            Bot.StartReceiving();
            Bot.OnCallbackQuery += CallBackButtons;
            Bot.OnMessage += CallBackNewMessage;
        }
        Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup startButtons = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
        {
            Keyboard = new[] {
                                                new[] // row 1
                                                {
                                                    new KeyboardButton("Оплатить складчину"),
                                                    new KeyboardButton("Вип доступ")
                                                },
                                                new[] // row 2
                                                {
                                                    new KeyboardButton("Личный кабинет"),
                                                    new KeyboardButton("Информация")
                                                },
                                            },
            ResizeKeyboard = true,
            OneTimeKeyboard = true//show buttons one time
        };
        private async void CallBackNewMessage(object sender, Telegram.Bot.Args.MessageEventArgs msg)
        {
            Message message = msg.Message;
            if (message.Text!=null) {
                if (message.Text == "/start")
                {
                    await Bot.SendTextMessageAsync(message.Chat.Id, "Здрастей", replyMarkup: startButtons);
                }
                if (message.Text.ToLower() == "оплатить складчину")
                {
                    var payOrNot = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(
                                                       new Telegram.Bot.Types.InlineKeyboardButtons.InlineKeyboardButton[][]
                                                       {
                                                                   new [] {
                                                                       new Telegram.Bot.Types.InlineKeyboardButtons.InlineKeyboardCallbackButton("Я оплатил","userPaid"),
                                                                       new Telegram.Bot.Types.InlineKeyboardButtons.InlineKeyboardCallbackButton("назад","back"),
                                                                   }
                                                       }
                                                  );
                    await Bot.SendTextMessageAsync(message.Chat.Id, "Оплатите пожалуйста N btc или N etc на счет", replyMarkup: payOrNot);
                }
                if (message.Text.ToLower() == "вип доступ")
                {
                    await Bot.SendTextMessageAsync(message.Chat.Id, "вип доступа пока нет, расскажешь что тут надо не помню уже", replyMarkup: startButtons);
                }
                if (message.Text.ToLower() == "личный кабинет")
                {
                    var lobby = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(
                                                       new Telegram.Bot.Types.InlineKeyboardButtons.InlineKeyboardButton[][]
                                                       {
                                                                   new [] {
                                                                       new Telegram.Bot.Types.InlineKeyboardButtons.InlineKeyboardCallbackButton("Мой статус","showStatus"),
                                                                       new Telegram.Bot.Types.InlineKeyboardButtons.InlineKeyboardCallbackButton("Настроить пересылку","showChannel"),
                                                                   }
                                                       }
                                                  );
                    await Bot.SendTextMessageAsync(message.Chat.Id, "Это ваш личный кабинет " + message.From.Username, replyMarkup: lobby);
                }
            }
        }
        private async void CallBackButtons(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
        {
            var message = e.CallbackQuery.Message;
            if (e.CallbackQuery.Data == "userPaid")
            {
                await Bot.SendTextMessageAsync(message.Chat.Id, "Отправьте пожалуйста TXID");
                //TODO: проверка taxID через блокчеин,
                //сделать условие если проверили сделать личный кабинет,
                //если не проверили вернуть прошлую позицию с сообщением что вы еще не оплатили.
                //await Bot.AnswerCallbackQueryAsync(e.CallbackQuery.Id, "красава мы скоро дадим вам доступ", true);
            }
            if (e.CallbackQuery.Data == "back")
            {
                await Bot.SendTextMessageAsync(message.Chat.Id, "Выберите пункт меню", replyMarkup: startButtons);
                await Bot.AnswerCallbackQueryAsync(e.CallbackQuery.Id); // отсылаем пустое, чтобы убрать "частики" на кнопке
            }
        }
        public async void sendMessage(TLMessage msg, string channelName, TeleSharp.TL.Upload.TLFile tfile)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                Random random = new Random();
                var ra= random.Next(1000);
                memStream.Write(tfile.Bytes, 0, tfile.Bytes.Length);
                using (var s = System.Drawing.Image.FromStream(memStream))
                {
                    s.Save(ra+"1.jpg");
                    foreach (var item in userId)
                    {
                        using (FileStream stream = new FileStream(ra+"1.jpg", FileMode.Open))
                        {
                           Message x= await Bot.SendPhotoAsync(item, new FileToSend("123.jpg", stream));
                        }
                    }
                }
            }
        }
        //TODO: В методах SendMessage реализовать все проверки пользователей на выбранный канал
        public void sendMessage(TLMessage msg,string channelName)
        {
            if (msg.Message!="") {
                foreach (var item in userId)
                {
                    Thread.Sleep(100);
                    Bot.SendTextMessageAsync(item,"*"+channelName+"*"+Environment.NewLine+msg.Message,Telegram.Bot.Types.Enums.ParseMode.Markdown);
                }
            }
        }
    }
}
