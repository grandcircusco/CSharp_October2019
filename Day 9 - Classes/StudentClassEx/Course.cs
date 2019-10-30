using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassEx
{
    class Course
    {
        #region fields
        private string name;
        private string instructor;
        private DateTime startDate;
        private DateTime endDate;
        private List<Student> studentList;
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public List<Student> StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }

        #endregion

        public Course() { }
        public Course(string _name, string _instructor, 
            DateTime _startDate, DateTime _endDate, List<Student> _studentList)
        {
            name = _name;
            instructor = _instructor;
            startDate = _startDate;
            endDate = _endDate;
            studentList = _studentList;
        }

        public Course(string _name, DateTime _startDate, DateTime _endDate)
        {
            name = _name;
            startDate = _startDate;
            endDate = _endDate;
        }
    }
}
