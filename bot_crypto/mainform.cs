using System;
using System.Windows.Forms;
using TeleSharp.TL.Messages;
using TLSharp.Core;
using System.IO.Compression;
using System.Linq;
using TeleSharp.TL;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using TeleSharp.TL.Channels;
using System.Collections.Generic;

namespace bot_crypto
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        StartBot client;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = {"testCryptoBotApp"/*,"Bitmex Money", "ELITE GROUP BITMEX"*/};
            client = new StartBot(str);
        }
    }
}
