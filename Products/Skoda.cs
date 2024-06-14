using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryHomework.Interfaces;

namespace FactoryHomework.Products
{
    internal class Skoda : IAbstractCar
    {
        private string _name = "Skoda";
        public string Name { get => _name; set => _name = value; }

        private bool _comesWithSpareTire = true;
        public bool ComesWithSpareTire { get => _comesWithSpareTire; set => _comesWithSpareTire = value; }
    }
}
