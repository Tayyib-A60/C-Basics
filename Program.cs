using System;

namespace C_Basics
{
     class Program
    {
        static void Main(string[] args)
        {
            var rofiah = new Student("Adeshina Rofiah", 23, Gender.Female, "500L");
            var ELT501 = new Course(3, 23, 49, "Engineering Techniques", "ELT501");
            var ELT502 = new Course(6, 13, 59, "Electronic III", "ELT502");
            var ELT503 = new Course(1, 13, 29, "Autocad", "ELT503");
            var ELT504 = new Course(2, 29, 69, "Power Switching Techniques", "ELT504");
            rofiah.AddCourse(ELT501);
            rofiah.AddCourse(ELT502);
            rofiah.AddCourse(ELT503);
            rofiah.AddCourse(ELT504);

            Console.WriteLine(rofiah.GetCalculatedCGPA());

            // Get Student Attributes as inputs and use them to create the student
            // Get how many courses a student is taking
            // Get each course attributes as inputs and use them to create a course
            // Add created course to student courses
            // Calculate Student GPA


            // Useful Resources
            // "Adeshina, Rofiah, Toyeeb".Split(",")  would result into [Adeshina, Rofiah, Toyeeb] as an array
            // Change Gender to char (temporarily)
            // Use for loop on method that get course inputs and create courses after getting how many courses a student offers
        }
    }
}