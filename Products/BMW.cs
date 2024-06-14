using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryHomework.Interfaces;

namespace FactoryHomework.Products
{
    internal class BMW : IAbstractCar
    {
        private string _name = "BMW";
        public string Name { get => _name; set => _name = value; }

        private bool _comesWithSpareTire = false;
        public bool ComesWithSpareTire { get => _comesWithSpareTire; set => _comesWithSpareTire = value; }
    }
}
