using System;

namespace C_Basics
{
    abstract class Car
    {
      // Atributes of a car

      public int Tire {get; set;}  
      public int doors {get; set;}
      public bool IsFourWheelDrive {get; set;}
      public bool IsAutomatic {get; set;}
      protected static string Name { get; set; }



      public virtual void DRIVE()
      {
          Console.WriteLine("The car moves forward or backwards");
      }

      public void DRIVE(int x)
      {
          Console.WriteLine("You entered {0}", x);
      }

      public abstract void Park();
    }


    class Benz : Car
    {
        public Benz(string name)
        {
            Name = name;
        }

        public override void DRIVE()
        {
            Console.WriteLine("Car can move forward, backwards, left and right too");

        }
        
        public override void Park()
        {
            Console.WriteLine("Parks Automatically");

        }

        public static void GetCarName()
        {
            Console.WriteLine("The name of this car is {0}", Name);
        }

    }
}