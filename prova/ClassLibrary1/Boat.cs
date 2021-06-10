using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Boat
    {
        private string name;
        private bool needLicense;
        private Licenses licenseType;
        private decimal hourlyCost;

        public abstract Licenses LicensesType { get; set; }

        public decimal GetRentalCost(TimeSpan rentalTime)
        {
            return (decimal)rentalTime.TotalHours * hourlyCost;
        }
    }
}
