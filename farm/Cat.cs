namespace farm
{
    class Cat : Felime
    {
        public override void makeSound()
        {
            OutVoices += "*cat noises*\n";
        }
        public override void eatFood(string food)
        {
            //всеядно е
        }

        public override void Output()
        {
            OutVoices += "Cat " + "[" + animalName + ", " + breed + ", " + animalWeight + ", " + livingRegion + ", " + foodEaten + "]";
        }
        public override void OutputAll(Mammal animal)
        {
            base.OutputAll(animal);
        }
    }
}
