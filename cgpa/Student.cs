using System;
using System.Collections.Generic;

namespace C_Basics
{
    public class Student
    {
        public Student(string name, int age, char gender, string level, int nuofcourses)
        {
            _name = name;
            _age = age;
            _level = level;
            _gender = gender;
            NumberOfCourses = nuofcourses;
            _studentCourses = new List<Course>();
        }
        // Create getter method for (name, age, level, gender)
        private string _name { get; set; }
        private int _age { get; set; }
        private string _level { get; set; }
        private float _cgpa { get; set; }
        public int NumberOfCourses { get; set; }
        private char _gender { get; set; }
        private List<Course> _studentCourses { get; set; } // We're likely to encounter an issue with this list

        public void AddCourse(Course courseToAdd)
        {
            _studentCourses.Add(courseToAdd);
        }

        public float GetCalculatedCGPA()
        {
            CalculateCGPA();
            return _cgpa;
        }

        private void CalculateCGPA()
        {
            var totalCGP = 0;
            var totalUnits = 0;

            for (int i = 0; i <= _studentCourses.Count-1; i++) {
                totalCGP += _studentCourses[i].GetGradePointAverage();
                totalUnits += _studentCourses[i].GetCourseUnits();
            }
            
            // Get CGP and Units for each course
            // Add total CGP and Units
            // Calculates

            _cgpa = (float)totalCGP/(float)totalUnits;
        }
    }
}