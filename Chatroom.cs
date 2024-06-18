using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal class Chatroom : IChatroom
    {
        private List<Chat> _chatHistory = new List<Chat>();
        private List<ICollegue> _chatters = new List<ICollegue>();

        public void AddChatter(ICollegue chatter)
        {
            _chatters.Add(chatter);
        }

        public void Recieve(Chat chat)
        {
            _chatHistory.Add(chat);
            Send(chat);
        }

        public void Send(Chat chat)
        {
            if(chat.Recipient != null)
            {
                chat.Recipient.Recieve(chat);
                chat.Sender.Recieve(chat);
            }
            else
            {
                foreach(var chatter in _chatters)
                {
                    chatter.Recieve(chat);
                }
            }
        }

        public void Print()
        {
            foreach (var chatter in _chatters)
            {
                Console.WriteLine(chatter.Name + "'s chat:");
                chatter.PrintChat();
                Console.WriteLine("\n");
            }
        }
    }
}
