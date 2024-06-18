using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal readonly struct Chat
    {
        public ICollegue Sender { get; }
        public ICollegue? Recipient { get; }
        public string Msg { get; }

        public Chat(ICollegue sender,string msg, ICollegue? recipient = null)
        {
            Sender = sender;
            Recipient = recipient;
            Msg = msg;
        }
    }
}
