using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student Mitch = new Student("Mitch");

            Mitch.AddGrade(90, 4.0);

            Console.WriteLine(Mitch.ToString());

            Teacher Justin = new Teacher("Justin", "Warren", "Coding", 2);

            Course Coding = new Course("Coding", Justin);

            Console.WriteLine("\n" + Coding.ToString());
        }
    }
}
