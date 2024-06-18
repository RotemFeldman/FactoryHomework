using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal interface ICollegue
    {
        string Name { get; }

        void Send(string msg, ICollegue recipient);

        void Recieve(Chat chat);

        void PrintChat();
    }
}
