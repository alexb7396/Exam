using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class VaccineCompany : Company, IHaveVaccine
    {
        private long VaccineNumber { get; set; }
        private List<DateTime> FreeDate { get; set; }
      
        public VaccineCompany(string name,string location,long vaccineNumber,List<DateTime>freeDate): base(name,location)
        {
            this.VaccineNumber = vaccineNumber;
            this.FreeDate = freeDate;
        }
        public Dictionary<string,DateTime> TakeVaccineReservation(Patient patient)
        {
           Dictionary<string, DateTime> patientVaccine = new Dictionary<string, DateTime>();
            if (CheckVaccine())
            {
                if (patient.Age >= 80 || patient.GetPathology())
                {
                    patientVaccine.Add("First vaccine: " + HOSPITAL.Genova.ToString(), this.FreeDate[0]);
                    DateTime second = CheckSecondVaccine(FreeDate[0]);
                    patientVaccine.Add("Second vaccine: " + HOSPITAL.Genova.ToString(), second);
                    FreeDate.Remove(FreeDate[0]);
                    FreeDate.Remove(second);
                    return patientVaccine;
                }
                else if (patient.Age >= 40 && patient.Age <= 80)
                {
                    DateTime date = SearchDate(7);
                    patientVaccine.Add("Single dose vaccine: " + HOSPITAL.LaSpezia.ToString(), date);
                    FreeDate.Remove(date);
                    return patientVaccine;
                }
                else if (patient.Age < 40 && patient.Age >= 0)
                {
                    DateTime date = SearchDate(31);
                    patientVaccine.Add("Single dose vaccine: " + HOSPITAL.Savona.ToString(), date);
                    return patientVaccine;
                }
            }
            throw new ApplicationException("No vaccine available");
        }
        public bool CheckVaccine()
        {
            if (this.VaccineNumber == 0)
                return false;
            else
                return true;
        }
        private DateTime CheckSecondVaccine(DateTime firstVaccine)
        {
            foreach(var date in this.FreeDate)
            {
                if ((date - firstVaccine).TotalDays >= 20 && (date - firstVaccine).TotalDays <= 25)
                {
                    return date;
                }
            }
            throw new ApplicationException("No dates are available for vaccines");
        }
        private DateTime SearchDate(int days)
        {
            foreach(var date in this.FreeDate)
            {
                if ((date - this.FreeDate[0]).TotalDays >= days)
                {
                    return date;
                }
            }
            throw new ApplicationException("No dates are available for vaccines");
        }
    }
}
