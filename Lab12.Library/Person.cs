using System;

namespace Lab12.Library
{
    public abstract class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            var output = $"Person[{Name}, {Address}]";
            return output;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetAddress()
        {
            return Address; 
        }
    }
}
