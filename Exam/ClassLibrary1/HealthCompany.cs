using System;
using System.Collections.Generic;

namespace ContactManagement
{
    public class HealthCompany : Company
    {
        public List<Citizen> PositiveCitizens { get; private set; }
        public List<Citizen> TrakedCitizens { get; private set; }

    }
}
