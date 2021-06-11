using System;
using System.Collections.Generic;

namespace ContactManagement
{
    public class HealthCompany : Company
    {
        public List<Citizen> PositiveCitizens { get; private set; }
        public List<Citizen> TrakedCitizens { get; private set;}
        public double PositivePercentage => (double)PositiveCitizens.Count / (double)TrakedCitizens.Count;

        public void AddPositiveCitizen(Citizen positiveCitizen)
        {
            PositiveCitizens.Add(positiveCitizen);
            TrakedCitizens.Add(positiveCitizen);
        }
        public void SwitchCitizenState(Citizen citizen,bool ToPositive)
        {

        }
    }
}
