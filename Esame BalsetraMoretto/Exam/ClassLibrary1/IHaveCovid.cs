using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManagement
{
    public interface IHaveCovid
    {
        public bool GetState();
        public bool ContactWithPositive { get; set; }
    }
}
