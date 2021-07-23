using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    public class Teacher : Occupation
    {
        private string Name = "";
        public Double Salary;

        public Teacher(string name, Double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public override string Whoami()
        {
            return this.Name + " is a Teacher";
        }
        public override double GetTax()
        {
            return this.Salary - (this.Salary * 0.09);
        }


    }
}
