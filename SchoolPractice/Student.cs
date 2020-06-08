using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double totalQualityScore = this.Gpa * NumberOfCredits;
            totalQualityScore += courseCredits * grade;
            this.NumberOfCredits += courseCredits;
            this.Gpa = totalQualityScore / NumberOfCredits;
        }
        public string GetGradeLevel(int credits)
        {
            if (credits <= 29)
            {
                return "Freshman";
            }
            else if (credits <= 59)
            {
                return "Sophomore";
            }
            else if (credits <= 89)
            {
                return "Junior";
            }
            else if (credits >= 90)
            {
                return "Senior";
            }
            else
            {
                return "Invalid number of credits.";
            }
        }

        public override string ToString()
        {
            return ($"{Name} (Credits: {NumberOfCredits}, GPA: {Gpa:0.0})\nGrade Level: {GetGradeLevel(NumberOfCredits)}");
        }


        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == this)
            {
                return true;
            }
            if (toBeCompared == null)
            {
                return false;
            }
            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return (s.StudentId == StudentId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
    }
}
