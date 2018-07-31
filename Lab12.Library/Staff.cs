using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12.Library
{
    public class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff(string name, string address, double pay) : base(name, address)
        {
            School = "Some school somewhere";
            Pay = pay;
        }

        public override string ToString()
        {
            return $"Staff[Person[{this.GetName()}, {this.GetAddress()}], {School}, {Pay}]";
        }
    }
}
