using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        TcpChannel channel;
        internal MyRemoteObject remoteObj;
        internal string userName = "user1";
        internal int key = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void portBtn_Click(object sender, EventArgs e)
        {
            JoinChat();
        }

        private void JoinChat()
        {
            if (portTxt.Text.Length != 0)
            {
                string url = "tcp://localhost:" + portTxt.Text + "/MyRemoteObjectName";
                channel = new TcpChannel();
                try
                {
                    ChannelServices.RegisterChannel(channel, true);
                }
                catch(RemotingException)
                {
                    MessageBox.Show("tcp channel already joined");
                }
               
                remoteObj = (MyRemoteObject)Activator.GetObject(typeof(MyRemoteObject), url);
                

                if (!remoteObj.JoinChat("user1"))
                {
                    MessageBox.Show("user already joined");
                }
                else
                {
                    remoteObj.SendMsgToSvr("user1 joined");
                }
            }

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            sendMessage();
            
        }

        private void sendMessage()
        {
           if(sendTxt.Text.Length != 0)
            {
                remoteObj.SendMsgToSvr(sendTxt.Text);
                sendTxt.Text = "";
            }
        }

        int counter = 4;
        private void timer(object sender, EventArgs e)
        {
            if(remoteObj != null)
            {
                string tmpStr = remoteObj.GetMsgFromSvr(key);
                if(tmpStr.Trim().Length > 0)
                {
                    key++;
                    richTextBox.Text = richTextBox.Text + "\n" + tmpStr;
                }
                if (counter > 3)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
        }
    }
}
