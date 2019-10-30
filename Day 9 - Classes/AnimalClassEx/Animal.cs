using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClassEx
{
    class Animal
    {
        private string name;
        private string type;
        private string sound;
        private bool fur;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public bool Fur
        {
            get { return fur; }
            set { fur = value; }
        }

        public Animal()
        {
        }

        public Animal(string name, string type, string sound, bool fur)
        {
            this.name = name;
            this.type = type;
            this.sound = sound;
            this.fur = fur;
        }

        public static List<string> GetAnimalTypes(List<Animal> animals)
        {
            List<string> animalTypes = new List<string>();
            foreach (Animal animal in animals) 
            { 
                if (!animalTypes.Contains(animal.Type))
                {
                    animalTypes.Add(animal.Type);
                }
            }
            return animalTypes;
        }

        public static void PrintAnimalTypes(List<Animal> animalList)
        {
            List<string> animalTypes = Animal.GetAnimalTypes(animalList);
            for (int i = 0; i < animalTypes.Count; i++)
            {
                Console.Write($"{animalTypes[i]}, ");
            }
        }

        public static void PrintAnimalByType(List<Animal> animalList, string selection)
        {
            for (int i = 0; i < animalList.Count; i++)
            {
                if (selection == animalList[i].Type)
                {
                    if (animalList[i].Fur)
                    {
                        Console.WriteLine($"{animalList[i].Name} is a {animalList[i].Type} " +
                            $"that has fur and says {animalList[i].Sound}.");
                    }
                    else
                    {
                        Console.WriteLine($"{animalList[i].Name} is a {animalList[i].Type} " +
                       $"that does not have fur and says {animalList[i].Sound}.");
                    }
                }
            }
        }
    }
}

