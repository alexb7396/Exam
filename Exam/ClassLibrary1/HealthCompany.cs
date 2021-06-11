﻿using System;
using System.Collections.Generic;

namespace ContactManagement
{
    public class HealthCompany : Company
    {
        public List<Citizen> PositiveCitizens { get; private set; }
        public List<Citizen> TrakedCitizens { get; private set;}
        public Dictionary<Citizen,List<Citizen>> GlobalContacts { get; private set; }
        public double PositivePercentage => (double)PositiveCitizens.Count / (double)TrakedCitizens.Count;

        public void AddTrakedCitizen(Citizen citizen)
        {
            TrakedCitizens.Add(citizen);
            if(citizen.GetState())
            {
                PositiveCitizens.Add(citizen);
            }
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
        public void UpdateGlobalContacts(Citizen interestedCitizen,List<Citizen> contacts)
        {
            if (!GlobalContacts.ContainsKey(interestedCitizen))
            {
                GlobalContacts.Add(interestedCitizen, new List<Citizen>());
            }
            foreach (var contact in contacts)
            {
                if (!GlobalContacts[interestedCitizen].Contains(contact))
                {
                    GlobalContacts[interestedCitizen].Add(contact);
                }
            }
        }
    }
}
