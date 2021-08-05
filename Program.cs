using System;

namespace C_Basics
{
     class Program
    {
        static void Main(string[] args)
        {
            // var rofiah = new Student("Adeshina Rofiah", 23, Gender.Female, "500L");
            // var ELT501 = new Course(3, 23, 49, "Engineering Techniques", "ELT501");
            // var ELT502 = new Course(6, 13, 59, "Electronic III", "ELT502");
            // var ELT503 = new Course(1, 13, 29, "Autocad", "ELT503");
            // var ELT504 = new Course(2, 29, 69, "Power Switching Techniques", "ELT504");
            // rofiah.AddCourse(ELT501);
            // rofiah.AddCourse(ELT502);
            // rofiah.AddCourse(ELT503);
            // rofiah.AddCourse(ELT504);

            // Console.WriteLine(rofiah.GetCalculatedCGPA());


            Console.WriteLine("welcome!...   Enter your details in the format :name, age, gender, level, number of courses" );
            Console.WriteLine("i.e. Adesokan Rofiah, 23, F, 500L, 9");
            var studentDetails = Console.ReadLine().Split(",");

            if (studentDetails.Length != 5){
                Console.WriteLine("input correct number of details");
                return;
            }

            var canConvertAge = Int32.TryParse(studentDetails[1].Trim(), out int age);
            if (canConvertAge == false){
                Console.WriteLine("Did not provide right age format");
                return;}

            var canConvertNoOfCourses = Int32.TryParse(studentDetails[4], out int noofcourses);
            if (canConvertNoOfCourses == false){
                Console.WriteLine("Did not provide right course format");
                return;}

            var canConvertgender = Char.TryParse(studentDetails[2], out char gender); 
            if (canConvertgender == false){
                Console.WriteLine("Did not provide right gender format");
                return;}

            var toyeeb = new Student(studentDetails[0], age, gender, studentDetails[3], noofcourses);

            for (int i = 0; i < noofcourses; i++){
                Console.WriteLine("Provide course detail in format: units, testScore, examScore, nameofcourse, courseCode");
                Console.WriteLine("i.e. 3, 31, 45, Electronics, ELE 324");

                var courseDetails = Console.ReadLine().Split(",");

                if (courseDetails.Length != 5){
                Console.WriteLine("input correct number of details");
                return;
                }

                var canConvertUnit = Int32.TryParse(courseDetails[0], out int unit);
                if (canConvertUnit == false)
                    return;

                var canConvertTest = Int32.TryParse(courseDetails[1], out int testScore);
                if (canConvertUnit == false)
                    return;

                var canConvertExam = Int32.TryParse(courseDetails[2], out int examScore);
                if (canConvertUnit == false)
                    return;

                var course = new Course (unit, testScore, examScore, courseDetails[3], courseDetails[4]);

                toyeeb.AddCourse(course);
            }

            Console.WriteLine(toyeeb.GetCalculatedCGPA());
            // var ele324 = new Course (3, 31, 45, "Electronics", "ELE 324");
            // var ele302 = new Course (3, 38, 42, "Electrical Cirsuit Theory 2", "ELE 302");
            // var ele312 = new Course (2, 38, 55, "Electronics", "ELE 324");

            // toyeeb.AddCourse(ele302);
            // toyeeb.AddCourse(ele312);
            // toyeeb.AddCourse(ele324);







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