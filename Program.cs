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

            var Rotem = new Chatter(chatroom,"Rotem");
            var Ilya = new Chatter(chatroom,"Ilya");
            var Tamir = new Chatter(chatroom, "Tamir");

            Rotem.Send("everyone can see this");
            Rotem.Send("only Ilya can see this", Ilya);
            Tamir.Send("Im angry");

            chatroom.Print();
        }
    }
}
