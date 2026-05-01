using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonatoinMatcher
{
    public class Hospital
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string BloodTypes { get; set; }


        public Hospital(string name, string adress, string phone, string bloodtypes) 
        {
            Name = name;
            Adress = adress;
            Phone = phone;
            BloodTypes = bloodtypes;
        }

    }

    
}
