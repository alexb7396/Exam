using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ContactManagement
{
    public class Citizen : Person, IHaveCovid 
    {
        private double ID { get; set; }
        private bool State { get; set; }
        private bool contactWithPositive;
        private List<Citizen> contact = new List<Citizen>();
        public bool GetState()
        {
            return State;
        }
        public void ChangeState()
        {
            State = !State;
        }
        public void ManageContact(Citizen citizien,TimeSpan contactTime)
        {
            if(contactTime.TotalMinutes>= 15 && !contact.Contains(citizien))
            {
                contactWithPositive = citizien.GetState();
                contact.Add(citizien);
            }
        }
    }
}
