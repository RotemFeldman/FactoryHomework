using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework.Interfaces
{
    internal interface IAbstractCar
    {
        string Name { get; set; }
        bool ComesWithSpareTire { get; set; }
    }
}
