using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassEx
{
    class Student
    {
        //fields
        private string firstName;
        private string secondName;
        private string major;
        private double gpa;
        private string email;

        #region properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName 
        {
            get 
            {
                return secondName;
            }
            set 
            {
                secondName = value;
            }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
        public Student()
        {

        }
        public Student(string _firstName, string _secondName, string _major, double _gpa, string _email)
        {
            firstName = _firstName;
            secondName = _secondName;
            major = _major;
            gpa = _gpa;
            email = _email;
        }

        public Student(string _firstName, string _secondName, string _email)
        {
            firstName = _firstName;
            secondName = _secondName;
            email = _email;
        }

    }
}
