using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Customer : Person, IHaveLicense
    {
        public Licenses? licence { get; set; }
        public Customer(string name, string surname, int age, Licenses licence) : base(name, surname, age)
        {
            this.licence = licence;
        }
        public bool GetLicence()
        {
            if (this.licence == null)
                return false;
            else
                return true;
        }
    }
}
