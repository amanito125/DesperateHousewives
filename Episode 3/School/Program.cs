namespace SchoolStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string schoolName = Console.ReadLine();

            School school = new School(schoolName);


            string[] command = Console.ReadLine().Split();

            Student student = null;


            while (command[0] != "End")

            {

                switch (command[0])

                {

                    case "Enroll":

                        student = new Student(command[1], command[2]);

                        school.EnrollStudent(student);

                        Console.WriteLine($"{student} was successfully enrolled!");

                        break;

                    case "Unenroll":

                        Student stdnt = school.UnenrollStudent(int.Parse(command[1]));

                        if (stdnt != null)

                        {

                            Console.WriteLine($"{stdnt} was successfully unenrolled!");

                        }

                        else

                        {

                            Console.WriteLine("No such Id in our database!");

                        }

                        break;

                    case "Print":

                        Console.WriteLine(school);

                        break;

                }


                command = Console.ReadLine().Split();

            }




        }
    }
}
