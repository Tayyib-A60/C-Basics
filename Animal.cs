using System;

namespace C_Basics
{
    abstract class Animal // Base Class
    {
        // Properties, Methods, Getters and Setters, Access Modifiers
        // public, private, protected, internal, protected internal
        // Inheritance and Polymorphism

        protected string AnimalClass { get; set; }

        public Animal()
        {
            AnimalClass = "An animal";
        }

        private void DoWhatAnAnimalDOes()
        {
            Console.WriteLine("DOing things");
        }

        public virtual void Talk()
        {
            Console.WriteLine($"Animal Talking");
        }

        public abstract void Walk();

    }

    interface ILivingThing
    {
        void MRNIGERD();
    }

    class LivingThing
    {
        public LivingThing()
        {
            
        }

        public void MRNIGERD()
        {
            Console.WriteLine("I can do MR NIGER D");
        }
    }



    class Cat : Animal, ILivingThing
    {
        // This constructor exists without we defining it
        public Cat()
        {
            AnimalClass = "Mammal";
        }

        // Properties or Attributes
        
        public bool HasWhiskers { get; set; } // General Syntax
        public int NoOfLegs { get; set; } // 4
        public int Tails { get; set; }
        public string Name { get; set; }

        public void MRNIGERD()
        {
            Console.WriteLine("I can do MR NIGER D");
        }



        // Methods
        public override void Talk()
        {
            Console.WriteLine($"{Name} says Meow, I am a {AnimalClass}");
        }
        public override void Walk()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }

    class HumanBeing
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsGay { get; set; }
        // public float Height { get; }
        public readonly float Height;

        public HumanBeing()
        {
            Height = 5.0f;
            Console.WriteLine("This is the human being constructor");
        }

        public void Talk()
        {
            Console.WriteLine($"{Name} says hi");
        }
    }

    // Read about interfaces, abstract classes, inheritance and polymorphism

    // Cars, Benz and BMW
}