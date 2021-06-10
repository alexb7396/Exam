using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Employee : Person
    {
        public double SerialNumber { get; set; }
        public double Salary { get; set; }
        public Employee()
        {

        }
        public Employee(double serialNumber, double salary)
        {
            this.SerialNumber = serialNumber;
            this.Salary = salary;
        }
    }
}
