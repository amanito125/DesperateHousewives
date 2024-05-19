using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff
{
    internal class Student
    {
        private static int id = 1;

        private int studentId;

        private string fullName;

        public Student(string firstName, string lastName)

        {

            this.studentId = id++;

            this.fullName = firstName + " " + lastName;

        }


        public string FullName

        {

            get { return fullName; }

            private set { fullName = value; }

        }


        public int StudentId

        {

            get { return studentId; }

            private set { studentId = value; }

        }

        public override string ToString()

        {

            return $"Student ID: {this.StudentId} Name: {this.FullName}";

        }
    }
}
