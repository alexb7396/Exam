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
        public void AddTrakedCitizen(Citizen citizen)
        {
            TrakedCitizens.Add(citizen);
        }
        public void SwitchCitizenState(Citizen citizen,bool ToPositive)
        {
            if (!TrakedCitizens.Contains(citizen))
            {
                throw new ApplicationException("This citizen is not traked");
            }
            else if(TrakedCitizens.Contains(citizen)&&!ToPositive)
            {
                throw new ApplicationException("This citizen is already non-positive");
            }
            else if (ToPositive && PositiveCitizens.Contains(citizen))
            {
                throw new ApplicationException("This citizen is already positive");
            }

            if(ToPositive)
            {
                PositiveCitizens.Add(citizen);
                if(!citizen.GetState())
                {
                    citizen.ChangeState();
                }
            }
            else
            {
                PositiveCitizens.Remove(citizen);
                if (citizen.GetState())
                {
                    citizen.ChangeState();
                }
            }
        }
    }
}
