using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Company
    {
        protected string CompanyName {get ; set; }
        protected string Location { get; set; }   
        public Company(string name,string location)
        {
            this.CompanyName = name;
            this.Location = location;
        }
    }
}
