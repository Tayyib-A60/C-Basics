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
        }
    }
}