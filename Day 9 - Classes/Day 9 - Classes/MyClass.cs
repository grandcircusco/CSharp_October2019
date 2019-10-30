using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9___Classes
{
    public class MyClass
    {
        //fields
        private string myProperty;

        //properties
        public string MyProperty
        {
            get
            {
                return myProperty;
            }
            set
            {
                myProperty = value;
            }
        }
        //methods
        //default constructor
        public MyClass()
        {

        }
        //overloaded constructor
        public MyClass(string _myProperty)
        {
            myProperty = _myProperty;
        }
    }
}
