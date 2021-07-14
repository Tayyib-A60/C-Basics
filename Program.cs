using System;

namespace C_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            // Readline Writeline
            // Console.WriteLine("Hello World!");

            // var textFromReadline = Console.ReadLine();

            // Console.WriteLine("You entered " + textFromReadline);

            // Variables and DataTypes

            // Primitive datatypes: string, int, double, float, decimal, boolean, char

            // string name = "Miss Hardesh";

            // char gender = 'F';

            // int age = 24;

            // double cgpa = 4.69;

            // decimal cgpaDec = 4.69m;

            // float cgpaFloat = -4.69f;

            // bool married = false;

            // bool foundSomeone = true;

            // bool loveHim = true;

            // Console.WriteLine("My name is " + name + ", I am a " + gender + " I am " + age + " years old");

            // Console.WriteLine($"My name is {name}, I am {age} years old");

            // Console.WriteLine("My name is {0}, I am {1} years old", name, age);

            // Math operations

            // Console.WriteLine(Math.Floor(cgpa));

            // Console.WriteLine(Math.Abs(cgpaFloat));

            // ConvertStringToNumber();

            var name = GetName();

            // Console.WriteLine(name);

            var cgpa = CalculateCGPA();
            Console.WriteLine(cgpa);

        }

       static void ConvertStringToNumber()
       {
           var scoreString = "55.5";

           Console.WriteLine(scoreString.GetType());

           var scoreNumber = Convert.ToDouble(scoreString);

           Console.WriteLine(scoreNumber.GetType());
       }

       static string GetName()
       {
        //    var name = "Adeshina Rofiah";

        //    return name;
            var val = Console.ReadLine();

            var canConvert = Int32.TryParse(val, out int numVal);

            Console.WriteLine("Wrong input");

            return "Adeshina Rofiah";
       }

       static double CalculateCGPA()
       {
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            Console.WriteLine("Enter your score for GNS 101"); // Score 23 units 2

            var gns101 = Convert.ToInt32(Console.ReadLine()); // Convert to number

            Console.WriteLine("Enter your score for CHM 101"); // Score 73 units 3

            var chm101 = Convert.ToInt32(Console.ReadLine()); // Convert to number

            Console.WriteLine("Enter your score for MTH 101"); // Score 53 units 3

            var mth101 = Convert.ToInt32(Console.ReadLine()); // Convert to 
            
            var cgp = 0;
            cgp += GetGrade(gns101) * 2; // cgp = 0
            cgp += GetGrade(chm101) * 3; // cgp = 5
            cgp += GetGrade(mth101) * 3; // cgp = 8

            double cgpa = cgp/8.0; // 8 is the sum of course units

            return cgpa;

            // Assignment
            // Take course units as inputs
            // Handle wrong inputs
            // Take all inputs as floating point values
       }

       static int GetGrade(int score)
       {
           var gp = 0;
           // 20, 89, 0, 44, 45, 58, 63, 72, 100
            if(score < 45) {
                gp += 0; // gpa = gpa + 0;
            } else if(score < 50) {
                gp += 2;
            } else if(score < 60) {
                gp += 3;
            } else if(score < 70) {
                gp += 4;
            } else {
                gp += 5;
            }

            return gp;
       }
    }
}
