using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManagement
{
    public class Citizen : Person, IHaveCovid 
    {
        private double ID { get; set; }
        private bool State { get; set; }
        private List<Citizen> contact = new List<Citizen>();
        public bool GetState()
        {
            return State;
        }
        public void ChangeState()
        {
            State = !State;
        }
    }
}
