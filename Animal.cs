using System;

namespace C_Basics
{
    class Animal
    {
        // Properties, Methods, Getters and Setters, Access Modifiers

    }

    class Cat
    {
        // This constructor exists without we defining it
        // public Cat()
        // {
            
        // }

        // Properties or Attributes
        public bool HasWhiskers { get; set; } // General Syntax
        public int NoOfLegs { get; set; } // 4
        public int Tails { get; set; }
        public string Name { get; set; }

        // Methods
        public void Talk()
        {
            Console.WriteLine($"{Name} says Meow");
        }
    }

    class HumanBeing
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsGay { get; set; }
        public float Height { get; set; }

        public HumanBeing()
        {
            Console.WriteLine("This is the human being constructor");
        }

        public void Talk()
        {
            Console.WriteLine($"{Name} says hi");
        }
    }
}