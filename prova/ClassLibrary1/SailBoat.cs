using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class SailBoat : Boat
    {
        private double length;
        private double weight; anno scadenza assicurazione

        public Licenses LicensesType
        {
            get
            {
                return licenseType;
            }
        }
        
        public SailBoat(string name, bool needLicense, Licenses licenseType,
            decimal hourlyCost) : base(name, needLicense, licenseType, hourlyCost) { }

        
    }
}
