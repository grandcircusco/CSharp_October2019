using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClassExample
{
    public class Person
    {
        //fields
        private string name;
        private DateTime dob;
        private string gender;

        //properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime DoB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        //methods
        public Person(string _name, DateTime _dob, string _gender) 
        {
            name = _name;
            dob = _dob;
            gender = _gender;
        }
    }
}
