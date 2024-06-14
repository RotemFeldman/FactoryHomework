using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryHomework.Interfaces;
using FactoryHomework.Products;

namespace FactoryHomework
{
    internal class AbstractCarFactory : IAbstractCarFactory
    {
        public IAbstractCar CreateBMW()
        {
            return new BMW();
        }

        public IAbstractCar CreateSkoda()
        {
            return new Skoda();
        }
    }
}
