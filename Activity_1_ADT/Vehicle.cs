using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_ADT
{
    internal class Vehicle
    {
        Person Per = new Person();
        public string   Type { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Wheels { get; set; }
        public string Color { get; set; }
        public void WomenCar()
        {
            if (Color != "Red")
            {
                Console.WriteLine("Sorry, this car cannot be registed");
            }
            else
            {
                
            }
        }

    }
}
