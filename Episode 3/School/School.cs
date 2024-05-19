using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff
{
    internal class School
    {
        private List<Student> students;

        private string name;

        public School(string name)

        {

            this.Name = name;

            this.Students = new List<Student>();

        }

        public string Name

        {

            get { return name; }

            private set { name = value; }

        }

        public List<Student> Students

        {

            get { return students; }

            private set { students = value; }

        }

        public void EnrollStudent(Student student)

        {

            this.Students.Add(student);

        }

        public Student UnenrollStudent(int id)

        {

            bool studentExists = this.Students.Any(s => s.StudentId == id);

            if (this.Students.Count <= 0 || !studentExists)

            {

                Console.WriteLine("No such id in our database!");

                return null;

            }

            else

            {

                var student = Students.FirstOrDefault(s => s.StudentId == id);

                this.Students.Remove(student);

                return student;


            }

        }

        public override string ToString()

        {

            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Name}:");

            foreach (var student in this.Students)

            {

                sb.AppendLine();

                sb.Append(student.ToString());

            }

            return sb.ToString();

        }
    }
}
