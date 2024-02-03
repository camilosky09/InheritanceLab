using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Employee
    {
        private string Id { get; set; }
        public string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private long Sin { get; set; }
        private string Dob { get; set; }
        private string Dept { get; set; }

        public Employee()
        {
        }

        public Employee(string id,
            string name,
            string address,
            string phone,
            long sin,
            string dob,
            string dept)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
        }

        public override string ToString()
        {
            return $"Id:{this.Id}, Name:{this.Name}, Address{this.Address}, Phone:{this.Phone}, SIN:{this.Sin}," +
                $"Date of Birth:{this.Dob}, Department:{this.Dept}";
        }
    }
}

