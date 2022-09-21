using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_ADT
{
    internal class Person
    {
        public string KeyCode { get; set; } 
        public string Name { get; set; }
        public string SurNames { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Boolean SuspicionOfFraud { get; set; }
        public List<License> Licenses { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Person> Registered { get; set; }

        public Person()
        {
            this.Licenses = new List<License>();
            this.Vehicles = new List<Vehicle>();
        }
        public void AddPerson(Person P)
        {
            if(P.Age >= 90)
            {
                Console.WriteLine("You Can't Be Registered");
            }
            else
            {
                this.Registered.Add(P);
            }
        }

    }
}
