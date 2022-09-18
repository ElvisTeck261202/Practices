using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_ADT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] Veh = new Vehicle[20];
            Person[] Per = new Person[20];
            License[] Lic = new License[20];
            Regist Reg = new Regist();
            
            Person Per1 = new Person();
            Vehicle Veh1 = new Vehicle();
            License Lic1 = new License();
            Per1.KeyCode = "DJSJD349CSJD2";
            Per1.Name = "Juan Perez";
            Per1.SurNames = "Alcachofas";
            Per1.Age = 20;
            Per1.Gender = "Male";
            Per1.SuspicionOfFraud = false;

            Veh1.Type = "Truck";
            Veh1.Year = 2022;
            Veh1.Brand = "Toyota";
            Veh1.Description = "White Truck with 4 cilinders motor";
            Veh1.Wheels = "Michelin Middle Live";
            Veh1.Color = "White";
            Per1.Vehicles.Add(Veh1);

            Lic1.KeyCode = Per1.KeyCode;
            Lic1.InitialDate = "May 6th 2022";
            Lic1.ExpirationDate = "May 6th 2025";
            Lic1.Status = true;
            Lic1.Type = "Vehicle License";
            Per1.Licenses.Add(Lic1);

            Reg.RegistPerson(Per1);
            Console.WriteLine("Hello");            

        }
    }
}

