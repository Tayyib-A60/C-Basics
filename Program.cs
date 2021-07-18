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

            // var name = GetName();

            // Console.WriteLine(name);
            // TupleType();

            var cgpa = CalculateCGPA();
            Console.WriteLine($"Your calculated cgpa is {cgpa}");

        }

       static void ConvertStringToNumber()
       {
           var scoreString = "55";

           if(scoreString.Length > 2) {
                return;
           }

           Console.WriteLine(scoreString.GetType());

           var scoreNumber = Convert.ToDouble(scoreString);

           Console.WriteLine(scoreNumber.GetType());
       }

        static void TupleType()
        {
            var tupleGrp1 = ("Rofiah", 25);
            Console.WriteLine($"My name is {tupleGrp1.Item1}, and I am {tupleGrp1.Item2}");
            var tupleGrp2 = ("Address", false, 'F');
            Console.WriteLine($"I live in {tupleGrp2.Item1}, I am {tupleGrp2.Item3} ");
        }
       

        static double CalculateCGPA()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your score for GNS 101"); // Score 23 
            var gns101 = GetScoreValue(); // Convert to floating point

            if(gns101.Item2 == false) { 
                Console.WriteLine("Your input for GNS 101 is invalid, program terminated"); 
                return 0;
            }
            
            Console.WriteLine("Enter your credit unit for GNS 101");
            var cdGns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your score for CHM 101"); // Score 73 
            var chm101 = GetScoreValue(); // Convert to floating point

            if(chm101.Item2 == false) { 
                Console.WriteLine("Your input for CHM 101 is invalid, program terminated"); 
                return 0;
            }

            Console.WriteLine("Enter your credit unit for CHM 101"); //credit unit
            var cdChm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your score for MTH 101"); // Score 53
            var mth101 = GetScoreValue(); // Convert to floating point 

            if(mth101.Item2 == false) { 
                Console.WriteLine("Your input for MTH 101 is invalid, program terminated"); 
                return 0;
            }

            Console.WriteLine("Enter your credit unit for MTH 101");
            var cdMth = Convert.ToInt32(Console.ReadLine());
            
            var cgp = 0;
            cgp += GetGrade(gns101.Item1) * cdGns; // cgp = 0
            cgp += GetGrade(chm101.Item1) * cdChm; // cgp = 5
            cgp += GetGrade(mth101.Item1) * cdMth; // cgp = 8

            var totalCredit = cdGns + cdChm +cdMth;

            double cgpa = cgp/totalCredit; // 8 is the sum of course units

            return cgpa;

            // Assignment
            // Take course units as inputs
            // Handle wrong inputs
            // Take all inputs as floating point values except for credit units
        }

        static (float, bool) GetScoreValue()
        {
            var val = Console.ReadLine();
            
            var canConvert = float.TryParse(val, out float numVal);

            if (canConvert == false) {
                Console.WriteLine("invalid input");
            }
            
            return (numVal, canConvert);
        }

        static int GetGrade(float score)
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
