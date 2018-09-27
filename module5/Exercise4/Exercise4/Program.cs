using System;

namespace Exercise4
{
    class Student
    {
        private double gradePointAverage;

        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        public Student()
        {
            Console.WriteLine("Hello from the first constructor");
        }
        public Student(int idNum, string lName, double gp)
        {
            IdNumber = idNum;
            LastName =  lName;
            GradePointAverage = gp;
        }

        public int IdNumber { get; set; }
        public string LastName { get; set; }
        public double GradePointAverage
        {
            get
            {
                return gradePointAverage;
            }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }
    }

    class CreateStudent
    {
        public static void Main()
        {
            Student first = new Student(999, "Billy", 3.2);
            Student second = new Student();

            second.IdNumber = 789;
            second.LastName = "Daniels";
            second.GradePointAverage = 4.1;
            Display(first);
            Display(second);
            Console.ReadLine();
        }

        private static void Display(Student stu)
        {
            Console.WriteLine("{0,5} {1, -10} {2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage);
        }
    }
}
