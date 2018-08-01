using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12.Library
{
    public class Staff : Person
    {
        // props
        private readonly string _school;
        private readonly double _pay;
        // ctor
        public Staff(string name, string address, double pay) : base(name, address)
        {
            _school = "Grand Circus";
            _pay = pay;
        }
        // override of ToString method to print out the converted string for staff
        public override string ToString()
        {
            return $"Staff[{base.ToString()}], {_school}, {_pay}]";
        }
    }
}
