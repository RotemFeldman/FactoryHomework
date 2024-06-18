using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal interface IChatroom
    {
        void Send(Chat chat);
        void Recieve(Chat chat);

        void AddChatter(ICollegue chatter);
    }
}
