using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Course(string topic, Teacher instructor)
        {
            Topic = topic;
            Instructor = instructor;
            Student Cait = new Student("Cait");
            Student Shea = new Student("Shea");
            this.EnrolledStudents = new List<Student> { Cait, Shea };
        }

        public override string ToString()
        {
            string formattedStudentList = "";
            foreach (Student student in EnrolledStudents) { formattedStudentList += student.Name + "\n"; }
            return $"Course Topic: {Topic}\nInstructor: {Instructor.FirstName + " " +  Instructor.LastName}\nEnrolled Students:\n{formattedStudentList}";
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Topic == course.Topic &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Topic, Instructor);
        }
    }
}
