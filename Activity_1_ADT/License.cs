using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_ADT
{
    internal class License

    {
       // DateTime Date = new DateTime(17,);

        public string KeyCode { get; set; }
        public int InitialDate { get; set; }
        public int ExpirationDate { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        public void AddLicense(License L, Person P)
        {
            bool AddLic = true;
            foreach(License Lic in P.Licenses)
            {
                if(Lic.Type == L.Type && Lic.Status == "Valid")
                {
                    Console.WriteLine("You have a valid license");
                    AddLic = false;
                    break;
                }
            }
            if (AddLic == true)
            {
                P.Licenses.Add(L);
            }
        }
    }
}
