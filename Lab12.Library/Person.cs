using System;

namespace Lab12.Library
{
    public abstract class Person
    {
        // super
        // props
        private readonly string _name;
        private readonly string _address;
        // ctor
        public Person(string name, string address)
        {
            _name = name;
            _address = address;
        }
        // override of the ToString method
        public override string ToString()
        {
            return $"Person[{_name}, {_address}]";
        }
        // Get access to the _name prop outside of this class
        public string GetName()
        {
            return _name;
        }
        // Get access to the _address prop outside of this class
        public string GetAddress()
        {
            return _address; 
        }
    }
}
