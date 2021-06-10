using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class BoatRental:Company
    {
        private List<Boat> harbour;
        private Queue<Employee> skippers;

        public Boat[] Boats
        {
            get
            {
                return harbour.ToArray();
            }
        }

        public int NumberOfBoats
        {
            get
            {
                return harbour.Count;
            }
        }

        public BoatRental(string name, string address) : base(name, address)
        {
            harbour = new List<Boat>();
            skippers = new Queue<Employee>();
        }

        public void AddBoats(params Boat[] boats)
        {
            foreach (var boat in boats)
            {
                harbour.Add(boat);
            }
        }

        public void AddEmployees(params Employee[] employees)
        {
            foreach (var employee in employees)
            {
                this.skippers.Enqueue(employee);
            }
        }

        public decimal RequestQuote(TimeSpan rentalTime, Boat interestedBoat)
        {
            return interestedBoat.GetRentalCost(rentalTime);
        }

        public bool RentBoat(Customer costumer, Boat interestedBoat)
        {
            if(harbour.Remove(interestedBoat))
            {
                if (costumer.licence != null && costumer.licence == interestedBoat.GetLicenseType())
                {
                    return true;
                }
                else if(skippers.Count>0)
                {
                    skippers.Dequeue();
                    return true;
                }
            }

            return false;
        }

        public bool CheckBoatAvailability(Boat interestedBoat)
        {
            return harbour.Contains(interestedBoat);
        }
    }
}
