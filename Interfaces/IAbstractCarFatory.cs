using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework.Interfaces
{
    interface IAbstractCarFactory
    {
        IAbstractCar CreateBMW();

        IAbstractCar CreateSkoda();
    }
}
