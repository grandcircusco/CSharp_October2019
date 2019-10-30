using System;
using System.Collections.Generic;

namespace AnimalClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>
            {
                new Animal("Whiskers", "Cat", "meow", true),
                new Animal("Scorsese", "Dog", "woof", true), 
                new Animal("William Snakespeare", "Snake", "hiss", false),
                new Animal("Nemo", "Fish", "dad", false),
                new Animal("Ron", "Rhino", "bellow", false),
                new Animal("Fluffy", "Bear", "rawr", true),
                new Animal("Nermal", "Cat", "meow", true),
                new Animal("Fido", "Dog", "woof", true)
            };

            //take in input from the user that allows the user to choose which animals
            //they would like shown to the console.

            Console.WriteLine("What kind of animal would you like to see?");
            Animal.PrintAnimalTypes(animalList);

            string selection = Console.ReadLine();

            Animal.PrintAnimalByType(animalList, selection);
        }
    }
}
