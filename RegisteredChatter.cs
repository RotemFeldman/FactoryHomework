using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal class RegisteredChatter : ICollegue
    {
        public readonly List<Chat> ChatHistory= new List<Chat>();


        private IChatroom _chatroom;

        public string Name {  get; }

        public RegisteredChatter(IChatroom chatroom, string name)
        {
            _chatroom = chatroom;
            _chatroom.AddChatter(this);
            Name = name;
        }

        public virtual void Recieve(Chat chat)
        {
            ChatHistory.Add(chat);
        }

        public virtual void Send(string msg, ICollegue recipient = null)
        {
            _chatroom.Recieve(new Chat(this,msg,recipient));
        }

        public void PrintChat()
        {
            foreach(Chat chat in ChatHistory)
            {
                if(chat.Recipient != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"[from {chat.Sender.Name} to {chat.Recipient.Name}]: {chat.Msg}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write($"[from {chat.Sender.Name}]: {chat.Msg}\n");
                }
            }
        }
    }
}
