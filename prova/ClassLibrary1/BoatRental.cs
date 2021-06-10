using System.Collections.Generic;

namespace ClassLibrary1
{
    public class BoatRental:Company
    {
        private Dictionary<Boat, int> harbour;

        public Boat[] Boats
        {
            get
            {
                List<Boat> boats = new List<Boat>();

                foreach (var type in harbour)
                {
                    boats.Add(type.Key);
                }
                return boats.ToArray();
            }
        }

        public int NumberOfBoats
        {
            get
            {
                int total = 0;

                foreach (var type in harbour)
                {
                    total += type.Value;
                }
                return total;
            }
        }

        public BoatRental(string name, string address) : base(name, address)
        {

        }

        public void AddBoat(Boat boat, int amount)
        {
            if (harbour.ContainsKey(boat))
            {
                harbour[boat] += amount;
            }
            else
            {
                harbour.Add(boat, amount);
            }
        }

        public bool RentBoat(Boat boat, int amount)
        {
            if (harbour.ContainsKey(boat))
            {
                harbour[boat] += amount;
            }
            else
            {
                harbour.Add(boat, amount);
            }
        }
    }
}
