using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Boat
    {
        public Licenses licenseType { get; private set; }
        internal decimal hourlyCost;

        public Licenses LicenseType 
        { 
            get 
            {
                return 
            } 
        }

        public Boat(string name, bool needLicense, Licenses licenseType, decimal hourlyCost)
        {
            this.licenseType = licenseType;
            this.hourlyCost = hourlyCost;
        }

        public decimal GetRentalCost(TimeSpan rentalTime)
        {
            return (decimal)rentalTime.TotalHours * hourlyCost;
        }
    }
}
