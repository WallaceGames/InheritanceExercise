using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird moltres = new Bird()
            {
                Name = "Moltres",
                Age = 1000,
                Legs = 2,
                HasBackbone = true,
                IsWarmBlooded = true,
                HasFeathers = false,
                Wings = 2,
                Type = "Fire",
            };

            Console.WriteLine($"{moltres.Name} is an {moltres.Type} pokemon that is {moltres.Age} years old and has " +
                $"{moltres.Legs} legs and {moltres.Wings} wings.");
            Console.WriteLine($"Is {moltres.Name} a vertebrate, warm blooded, and has feathers? " +
                $"{moltres.HasBackbone}, {moltres.IsWarmBlooded}, and {moltres.HasFeathers}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile dragon = new Reptile()
            {
                Name = "Rayquaza",
                Age = 2000,
                Legs = 0,
                HasBackbone = true,
                IsColdBlooded = true,
                Environment = "Space",
                Defense = "laser beam",
            };

            Console.WriteLine($"{dragon.Name} is a {dragon.Age} year old being that resides in {dragon.Environment}," +
                $" {dragon.Defense}, and has {dragon.Legs} legs");
            Console.WriteLine($"Is {dragon.Name} a vertebrate, cold blooded, and has scales?" +
                $"{dragon.HasBackbone},{dragon.IsColdBlooded}, and {dragon.HasScales}");
            Console.WriteLine();
        }
    }
}
