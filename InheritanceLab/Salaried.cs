using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Salaried : Employee
    {
        private double Salary { get; set; }

        public Salaried() { }

        public Salaried(string id,
            string name,
            string address,
            string phone,
            long sin,
            string dob,
            string dept,
            double salary) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Salary = salary;
        }

        public double getPay()
        {
            return this.Salary;
        }

        public override string ToString()
        {
            return "Salary is " + this.Salary;
        }
    }
}
