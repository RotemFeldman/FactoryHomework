using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal class GuestChatter : RegisteredChatter
    {
        public GuestChatter(IChatroom chatroom, string name) : base(chatroom, name)
        {
        }

        public override void Send(string msg, ICollegue recipient)
        {
            base.Send(msg, recipient);
        }
    }
}
