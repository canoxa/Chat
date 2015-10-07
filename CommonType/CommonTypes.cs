using System;
using System.Collections;

namespace Chat
{

    public class MyRemoteObject : MarshalByRefObject
    {
        static void Main(string[] args)
        {
        }
        Hashtable ChatMsg = new Hashtable();
        ArrayList ChatUsers = new ArrayList();
        private int key = 0;
        public bool JoinChat(string name)
        {
            if(ChatUsers.IndexOf(name) > -1)
            {
                return false;
            }
            else
            {
                ChatUsers.Add(name);
                return true;
            }
        }

        public void SendMsgToSvr(string msg)
        {
            ChatMsg.Add(++key, msg);
        }

        public string GetMsgFromSvr(int lastKey)
        {
            if(key > lastKey)
            {
                return ChatMsg[lastKey + 1].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
