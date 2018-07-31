using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12.Library
{
    public class Student : Person
    {
        // props
        private readonly string _program;
        private readonly int _year;
        private readonly double _fee;
        // ctor
        public Student(string name, string address, double fee) : base(name, address)
        {
            _program = ".Net";
            _year = 2019;
            _fee = fee;
        }
        // override of the to string method to print out the formatted string for students
        public override string ToString()
        {
            return $"Student[Person[{this.GetName()}, {this.GetAddress()}], {_program}, {_year}, {_fee}]";
        }
    }
}
