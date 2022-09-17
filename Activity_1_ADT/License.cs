using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_ADT
{
    internal class License
    {
        Person Per = new Person();
        public string KeyCode { get; set; }
        public string InitialDate { get; set; }
        public string ExpirationDate { get; set; }
        public Boolean Status { get; set; }
        public string Type { get; set; }
        private List <License> Lic { get; set; }

        private License()
        {
            this.Lic = new List <License>();
        }
        public void AddLicense(License Person)
        {
            if (Person.Per.Age >= 90)
            {
                Console.WriteLine("You cannot register with more than 90 years old");
            }
            else
            {
                Lic.Add(Person);
            }
        }
    }
}
