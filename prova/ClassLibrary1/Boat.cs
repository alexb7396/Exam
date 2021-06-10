using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Boat
    {
        public decimal HourlyCost { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public DateTime Registration { get; set;}
        public DateTime Expiry { get; set; }

        public abstract Licenses LicenseType();

        public decimal GetRentalCost(TimeSpan rentalTime)
        {
            return (decimal)rentalTime.TotalHours * HourlyCost;
        }
    }
}
