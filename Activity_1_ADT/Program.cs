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
            Vehicle Veh = new Vehicle();
            Person Per = new Person();
            License Lic = new License();
            bool Exit = false;
            while(Exit != true)
            {
                Console.WriteLine("What do you want to do?" + "\n" + "1.- Add Person" + "\n" + "2.- Enter a Person" + "\n" + "3.- Exit");
                string Option = Console.ReadLine();
                switch (Option)
                {
                    case "1":
                        Console.WriteLine("You choose Add a Person");
                        Console.WriteLine("Write the name");
                        string Name = Console.ReadLine();
                        Per.Name = Name;
                        Console.WriteLine("Write the surname");
                        string SurNames = Console.ReadLine();
                        Per.SurNames = SurNames;
                        Console.WriteLine("Write the KeyCode");
                        string KeyCode = Console.ReadLine();
                        Per.KeyCode = KeyCode;
                        Console.WriteLine("Write the age");
                        int Age = Convert.ToInt32(Console.ReadLine());
                        Per.Age = Age;
                        Console.WriteLine("Write the gender");
                        string Gender = Console.ReadLine();
                        Per.Gender = Gender;
                        Per.AddPerson(Per);

                        break;

                    case "2":
                        Console.WriteLine("Enter KeyCode");
                        string Key = Console.ReadLine();
                        foreach (Person P in Per.Registered)
                        {
                            if(P.KeyCode == Key)
                            {
                                Per = P;
                            }
                        }
                        bool user = true;
                        while (user == true)
                        {
                            Console.WriteLine("welcome" + Per.Name);
                            Console.WriteLine("1.- Add a car" + "\n" + "2.- Add a license" + "3.- Cancel Car" + "\n" + "4.- Exit");
                            string Ops = Console.ReadLine();
                            switch (Ops)
                            {
                                case "1":
                                    Console.WriteLine("Type of the car");
                                    string Type = Console.ReadLine();
                                    Veh.Type = Type;
                                    Console.WriteLine("Year of the car");
                                    int Year = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Brand of the car");
                                    string Brand = Console.ReadLine();
                                    Veh.Brand = Brand;
                                    Console.WriteLine("Write the description");
                                    string Description = Console.ReadLine();
                                    Veh.Description = Description;
                                    Console.WriteLine("Wheels of the car");
                                    string Wheels = Console.ReadLine();
                                    Veh.Wheels = Wheels;
                                    Console.WriteLine("Color of the car");
                                    string Color = Console.ReadLine();
                                    Veh.Color = Color;
                                    Veh.AddVehicle(Veh, Per);

                                    break;

                                case "2":
                                    Lic.KeyCode = Per.KeyCode;
                                    Console.WriteLine("Write the initial date of your license");
                                    int Initial = Convert.ToInt32(Console.ReadLine());
                                    Lic.InitialDate = Initial;
                                    Console.WriteLine("Write the expiration of your license");
                                    int Expiration = Convert.ToInt32(Console.ReadLine());
                                    Lic.ExpirationDate = Expiration;
                                    Console.WriteLine("Write the status of your license");
                                    string Status = Console.ReadLine();
                                    Lic.Status = Status;
                                    Console.WriteLine("Write the type of your license");
                                    string TypeLic = Console.ReadLine();
                                    Lic.Type = TypeLic;
                                    Lic.AddLicense(Lic, Per);

                                    break;

                                case "3":
                                    Veh.CancelCar(Per);

                                    break;

                                case "4":
                                    user = false;

                                    break;

                                default:
                                    Console.WriteLine("You selected a unexistent option, Try Again");

                                    break;
                            }
                        }

                        break;

                    case "3":
                        Exit = true;

                        break;

                    default:
                        Console.WriteLine("You selected an unexitent option");

                        break;


                }
            }
        }
    }
}

