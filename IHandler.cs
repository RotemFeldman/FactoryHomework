using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal interface IHandler
    {
        IHandler Next { get; }

        void SetNext(IHandler handler);

        void Handle();
    }
}
