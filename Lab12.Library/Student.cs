using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12.Library
{
    public class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student(string name, string address, double fee) : base(name, address)
        {
            Program = ".Net";
            Year = 2019;
            Fee = fee;
        }

        public override string ToString()
        {
            var output = $"Student[Person[{this.GetName()}, {this.GetAddress()}], {Program}, {Year}, {Fee}]";
            return output;
        }
    }
}
