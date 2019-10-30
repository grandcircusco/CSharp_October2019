using System;
using System.Collections.Generic;

namespace Day_1___Inheritance_and_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("Badger");
            animal1.MakeSound();

            Dog dog1 = new Dog("Rover", 17);
            Dog dog2 = new Dog("Odie", 4);
            Dog dog3 = new Dog("Jameson", 0);

            dog1.MakeSound();

            Cat cat1 = new Cat("Mr. Pickles", 22);
            Cat cat2 = new Cat("Mr. Mittens", 20);
            Cat cat3 = new Cat("Mr. Purrfect", 21);

            List<Animal> animalList = new List<Animal> { animal1, dog1, dog2, dog3, cat1, cat2, cat3 };

            foreach(Animal animal in animalList)
            {
                if(animal is Cat)
                {
                    Cat cat = (Cat)animal;
                    cat.AddHoursSlept();
                    cat.MakeSound();
                }
                else if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    dog.FetchAStick();
                }
                else
                {
                    animal.MakeSound();
                }
            }
        }
    }
}
