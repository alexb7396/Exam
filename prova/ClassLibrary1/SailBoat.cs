using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class SailBoat : Boat
    {
        private Licenses license = Licenses.A;

        public override Licenses LicenseType()
        {
            return this.license;
        }
    }
}
