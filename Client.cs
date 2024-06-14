using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryHomework.Interfaces;
using FactoryHomework.Products;

namespace FactoryHomework
{
    internal class Client
    {
        private IAbstractCarFactory _carFactory;

        public Client(IAbstractCarFactory carFactory)
        {
            _carFactory = carFactory;
        }

        public BMW CreateBMW()
        {
            var car = _carFactory.CreateBMW();

            car.Name = "Used BMW";

            return (BMW)car;
        }

        public Skoda CreateSkoda()
        {
            var car = _carFactory.CreateSkoda();

            car.Name = "Used Skoda";

            return (Skoda)car;
        }
    }
}
