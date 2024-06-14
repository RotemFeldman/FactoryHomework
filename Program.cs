using System.Data;

namespace FactoryHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractCarFactory factory = new AbstractCarFactory();

            Client c = new Client(factory);

            var car = c.CreateSkoda();

            Console.WriteLine(car.Name + " " + car.ComesWithSpareTire);

        }
    }
}
