using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new Chatroom();

            var Rotem = new RegisteredChatter(chatroom,"Rotem");
            var Ilya = new RegisteredChatter(chatroom,"Ilya");
            var Tamir = new RegisteredChatter(chatroom, "Tamir");

            var Guest1 = new GuestChatter(chatroom, "Guest1");
            var Guest2 = new GuestChatter(chatroom, "Guest2");


            Rotem.Send("this is a public message, everyone can see this");
            Rotem.Send("this is a private message, only Ilya can see this", Ilya);
            Tamir.Send("hello world");
            Guest1.Send("im a guest so i can only send private messages", Guest2);
            Guest2.Send("me too", Guest1);
            Ilya.Send("I think its working!");

            chatroom.Print();
        }
    }
}
