using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ContactManagement
{
    public class Citizen : Person, IHaveCovid 
    {
        public double ID { get; private set; }
        public bool State { get; private set; }
        public bool ContactWithPositive { get; set; }
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
                ContactWithPositive = citizien.GetState();
                contact.Add(citizien);
            }
        }
    }
}
