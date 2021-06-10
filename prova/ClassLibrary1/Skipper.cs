using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Skipper : Employee, IAmAvaible
    {
        private bool availability = true;
        public Skipper(double serialNumber,double salary): base(serialNumber,salary)
        {
        }
        public bool CheckAvailability()
        {
            if (this.availability == true)
                return true;
            else
                return false;
        }
        public void ChangeAvailability()
        {
            this.availability = !availability;
        }
    }
}
