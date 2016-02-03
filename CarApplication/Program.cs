using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car object
            Car car = new Car();
            car.Speed = 300;
            car.Height = 5.0;
            Console.WriteLine("Speed is {0} and height {1}", car.Speed, car.Height);
        }
    }
}
