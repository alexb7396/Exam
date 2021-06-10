using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class MotorBoat : Boat
    {
        private Licenses licence = Licenses.B;
        public override Licenses LicenseType()
        {
            return this.licence;
        }
    }
}




