using System;

namespace C_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // var car1 = new Car();
            // car1.Tire = 4;
            // car1.doors = 2;
            // car1.IsFourWheelDrive = false;
            // car1.IsAutomatic = true;

            // car1.DRIVE();

            var benzGlt = new Benz("Benzi oloye");
            benzGlt.Tire = 4;
            benzGlt.doors = 4;
            benzGlt.IsFourWheelDrive = true;
            benzGlt.IsAutomatic = true;

            Benz.GetCarName();

            Console.WriteLine("Enter the following in the format below. Name, Age, Gender, Level");
            Console.WriteLine("i.e. Adesokan Rofiah, 23, F, 500L");

            var studentDetails = Console.ReadLine().Split(",");

            Console.WriteLine(studentDetails[3].Trim());


            // benzGlt.DRIVE();
            // benzGlt.DRIVE(5);
            // benzGlt.Park();


            // var student = new Student("name", 23, 'F');





            // var cat1 = new Cat();
            // cat1.Name = "Ambi";
            // cat1.NoOfLegs = 4;
            // cat1.Tails = 1;
            // cat1.HasWhiskers = true;
            // // cat1.AnimalClass = "Mammal";

            // // Console.WriteLine(cat1);
            // cat1.Talk();
            // cat1.Walk();
            // cat1.MRNIGERD();

            // if(cat1 is Animal)
            // {
            //     var animal = cat1 as Animal;
            //     var animal2 = (Animal)cat1;
            //     Console.WriteLine("A cat is an animal");
            // }


            // var animal = new Animal(); // Can't create an instance of an abstract class or an interface

           
        }

        static void ForLoop(int count)
        {
            // for(int i = 0; i <= count; i++)
            // {
            //     Console.WriteLine(i);
            // }

            for(int i = count; i > 0; i -= 2) // i -= 2 is i = i - 2
            {
                Console.WriteLine(i);
            }
        }

        static void WhileLoop(int count)
        {
            // 10
            // while(count >= 0)
            // {
            //     Console.WriteLine(count);
            //     count--;
            // }

            var i = 0;

            while(count >= i)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Switcher(char gender)
        {
            switch(gender)
            {
                case 'M':
                    Console.WriteLine("You are a man");
                break;
                case 'F':
                    Console.WriteLine("You're a woman");
                break;
                default:
                    Console.WriteLine("You're a bastard");
                break;
            }
        }

        static void InitialLessons()
        {
            // Readline Writeline
            Console.WriteLine("Hello World!");

            var textFromReadline = Console.ReadLine();

            Console.WriteLine("You entered " + textFromReadline);

            // Variables and DataTypes

            // Primitive datatypes: string, int, double, float, decimal, boolean, char

            string name = "Miss Hardesh";

            char gender = 'F';

            int age = 24;

            double cgpa = 4.69;

            // decimal cgpaDec = 4.69m;

            float cgpaFloat = -4.69f;

            // bool married = false;

            // bool foundSomeone = true;

            // bool loveHim = true;

            Console.WriteLine("My name is " + name + ", I am a " + gender + " I am " + age + " years old");

            Console.WriteLine($"My name is {name}, I am {age} years old");

            Console.WriteLine("My name is {0}, I am {1} years old", name, age);

            // Math operations

            Console.WriteLine(Math.Floor(cgpa));

            Console.WriteLine(Math.Abs(cgpaFloat));

            ConvertStringToNumber();

            Console.WriteLine(name);
            TupleType();

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
            var cdGns = GetCreditValue();

            if (cdGns.Item2 == false) {
                Console.WriteLine("Invalid input");
                return 0;
            }

            Console.WriteLine("Enter your score for CHM 101"); // Score 73 
            var chm101 = GetScoreValue(); // Convert to floating point

            if(chm101.Item2 == false) { 
                Console.WriteLine("Your input for CHM 101 is invalid, program terminated"); 
                return 0;
            }

            Console.WriteLine("Enter your credit unit for CHM 101"); //credit unit
            var cdChm = GetCreditValue();

            if (cdChm.Item2 == false) {
                Console.WriteLine("Invalid input");
                return 0;
            }

            Console.WriteLine("Enter your score for MTH 101"); // Score 53
            var mth101 = GetScoreValue(); // Convert to floating point 

            if(mth101.Item2 == false) { 
                Console.WriteLine("Your input for MTH 101 is invalid, program terminated"); 
                return 0;
            }

            Console.WriteLine("Enter your credit unit for MTH 101");
            var cdMth = GetCreditValue();

            if (cdMth.Item2 == false) {
                Console.WriteLine("Invalid input");
                return 0;
            }
            
            var cgp = 0;
            cgp += GetGrade(gns101.Item1) * cdGns.Item1; // cgp = 12
            cgp += GetGrade(chm101.Item1) * cdChm.Item1; // cgp = 9
            cgp += GetGrade(mth101.Item1) * cdMth.Item1; // cgp = 10

            var totalCredit = cdGns.Item1 + cdChm.Item1 + cdMth.Item1;

            double cgpa = cgp/(float)totalCredit; // casting to float => (float)value

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

            if(numVal < 0){
                canConvert = false;
            }
 
            return (numVal, canConvert);
        }
        static (int, bool) GetCreditValue()
        {
            var val = Console.ReadLine();
            
            var canConvert = Int32.TryParse(val, out int numVal);

            if(numVal < 0){
                canConvert = false;
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
