using System;
using System.Collections.Generic;

namespace C_Basics
{
    public class Student
    {
        public Student(string name, int age, char gender, string level)
        {
            _name = name;
            _age = age;
            _level = level;
            _gender = gender;
        }
        // Name, Age, Level, Gender, List<Course> Courses
        private string _name { get; set; }
        private int _age { get; set; }
        private string _level { get; set; }
        private float _cgpa { get; set; }
        private char _gender { get; set; } // Act
        private List<Course> _studentCourses { get; set; }

        public void AddCourse(Course courseToAdd)
        {
            _studentCourses.Add(courseToAdd);
        }

        public float GetCalculatedCGPA()
        {
            return _cgpa;
        }

        private float CalculateCGPA()
        {
            var totalCGP = 0;
            var totalUnits = 0;

            for (int i = 0; i <= _studentCourses.Count-1; i++){
                totalCGP += _studentCourses[i].GetGradePointAverage();
                totalUnits += _studentCourses[i].GetCourseUnits();
            }
            
            // Get CGP and Units for each course
            // Add total CGP and Units
            // Calculates

            return (float)totalCGP/(float)totalUnits;
        }
    }
}