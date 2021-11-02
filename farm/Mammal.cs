using System;
using System.Collections.Generic;
using System.Text;

namespace farm
{
    abstract class Mammal:Animal
    {
        public static string[] newAnimal;
        public static List<string> allAnimals = new List<string>();
        public virtual void OutputAll(Mammal animal)
        {
            if(newAnimal[0]!="End")
            {
                if (newAnimal[0] == "Cat")
                {
                    animal.animalName = newAnimal[1];
                    animal.breed = newAnimal[4];
                    animal.animalWeight = double.Parse(newAnimal[2]);
                    animal.livingRegion = newAnimal[3];
                    animal.foodEaten = int.Parse(newAnimal[6]);
                    animal.makeSound();
                    animal.eatFood(newAnimal[5]);
                    animal.Output();
                    allAnimals.Add(animal.OutVoices);
                }
                else
                {
                    animal.animalName = newAnimal[1];
                    animal.animalWeight = double.Parse(newAnimal[2]);
                    animal.livingRegion = newAnimal[3];
                    animal.foodEaten = int.Parse(newAnimal[5]);
                    animal.makeSound();
                    animal.eatFood(newAnimal[4]);
                    animal.Output();
                    allAnimals.Add(animal.OutVoices);
                }
            }
        }
    }
}
