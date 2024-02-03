using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Part_time : Employee
    {
        private double Rate { get; set; }

        private double Hours { get; set; }

        public Part_time()
        {
        }

        public Part_time(string id,
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
            return Rate * Hours;
        }

        public override string ToString()
        {
            return "Part-time pay is: " + getPay();
        }
    }
}
