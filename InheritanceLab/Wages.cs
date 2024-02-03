using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Wages : Employee
    {
        private double Rate { get; set; }

        private double Hours { get; set; }

        public Wages() { }

        public Wages(string id,
            string name,
            string address,
            string phone,
            long sin,
            string dob,
            string dept,
            double rate,
            double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Rate = rate;
            this.Hours = hours;
        }
        public double getPay()
        {
            if (Hours > 40)
            {
                double regularPay = Rate * 40;
                double OverTimeHours = Hours - 40;
                double OverTimeWage = OverTimeHours * (Rate * 1.5);
                return OverTimeWage + regularPay;

            }
            else
                return Rate * Hours;
        }
    }
}

