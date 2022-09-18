using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_ADT
{
    internal class Regist
    {
        private Boolean Registered = true;
        private List<Person> Register { get; set; }
        public Regist()
        {
            this.Register = new List<Person>();
        }

        public void RegistPerson(Person Person)
        {
            if (Person.Age >= 90)
            {
                Console.WriteLine("You can't be registered");
                Registered = false;
            }
            else
            { 
                if (Person.Gender == "Women")
                {
                    foreach(Vehicle V in Person.Vehicles)
                    {
                        if(V.Color != "Red")
                        {
                            Console.WriteLine("You can't be registered");
                            Registered = false;
                            break;
                        }
                    }
                }
                else
                {
                    foreach(Vehicle V in Person.Vehicles)
                    {
                        if(V.Brand != "Toyota" && V.Brand != "Ford")
                        {
                            Console.WriteLine("You can't be registered");
                            Registered = false;
                            break;
                        }
                    }
                }
                if(Registered == true)
                {
                    this.Register.Add(Person);
                }
            }
        }
    }
}

