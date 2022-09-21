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
        public string Type { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Wheels { get; set; }
        public string Color { get; set; }

        public void AddVehicle(Vehicle V, Person P)
        {
            bool RegistCar = true;
            if (P.Gender == "Women" && V.Color != "Red")
            {
                Console.WriteLine("You cannot regist this car");
                RegistCar = false;
            }
            else if (P.Gender == "Men" && V.Brand != "Toyota" || V.Brand != "Ford")
            {
                Console.WriteLine("You Cannot regist this car");
                RegistCar = false;
            }
            else if (P.Vehicles.Count >= 5)
            {
                Console.WriteLine("You cannot regist more than 5 vehicles");
                P.SuspicionOfFraud = true;
                RegistCar = false;
            }
            else if (P.Licenses.Count == 0)
            {
                Console.WriteLine("You don't have a license to regist a car");
            }
            foreach (License L in P.Licenses)
            {
                if (L.Status == "Expired")
                {
                    Console.WriteLine("You license is expired");
                    break;
                }

                if (RegistCar == true)
                {
                    P.Vehicles.Add(V);
                }
            }
        }

        public void CancelCar(Person Per)
        {
            int CarToCancel = 0;
            foreach(Vehicle V in Per.Vehicles)
            {
                Console.WriteLine(Convert.ToString(CarToCancel) + " .- " + V);
                CarToCancel += 1;
            }
            Console.WriteLine("What car do you want to cancel?");
            int CancelCar = Convert.ToInt32(Console.ReadLine());
            Per.Vehicles.RemoveAt(CancelCar);
        }
    }
}
