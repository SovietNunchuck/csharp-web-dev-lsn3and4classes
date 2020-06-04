using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        private List<string> Roster { get; set; } = new List<string>();
        private Dictionary<string, char> Grades { get; set; } = new Dictionary<string, char>();
        private string CourseCode { get; set; }

    }
}
