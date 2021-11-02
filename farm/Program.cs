using System;

namespace farm
{
    class Program
    {
        public static Mammal animal;
        static void Main(string[] args)
        {
            string end = "End";
            do
            {
                Mammal.newAnimal = Console.ReadLine().Split();
                if (Mammal.newAnimal[0] == null || Mammal.newAnimal[0] == "") continue;
                if (Mammal.newAnimal[0] == "Zebra")
                {
                    animal = new Zebra();
                }
                else if (Mammal.newAnimal[0] == "Mouse")
                {
                    animal = new Mouse();
                }
                else if (Mammal.newAnimal[0] == "Cat")
                {
                    animal = new Cat();
                }
                else if (Mammal.newAnimal[0] == "Tiger")
                {
                    animal = new Tiger();
                }
                animal.OutputAll(animal);
            }
            while (Mammal.newAnimal[0] != end);
            Console.WriteLine();
            for (int i = 0; i < Mammal.allAnimals.Count; i++)
            {
                Console.WriteLine(Mammal.allAnimals[i]);
                Console.WriteLine("-----------------------------");
            }
        }
    }    
}

