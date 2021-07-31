using System;
using System.Collections.Generic;

namespace C_Basics
{
    public class Student
    {
        // Name, Age, Level, Gender, List<Course> Courses
        public string Name { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }
        public char Gender { get; set; }
        public List<Course> Courses { get; set; }
    }
}