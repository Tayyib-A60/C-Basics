using System;
using System.Collections.Generic;

namespace C_Basics
{
    class Student
    {
        // Name, Age, Level, Gender, List<Course> Courses
        public string Name { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }
        public char Gender { get; set; }
        public List<Course> Courses { get; set; }
    }

    class Course
    {
        public int Units { get; set; }
        public float TestScore { get; set; }
        public float ExamScore { get; set; }
        public string Name { get; set; }
        public char Grade { get; set; }
        public string CourseCode { get; set; }
        public int GradePoint { get; set; }
        
    }
}