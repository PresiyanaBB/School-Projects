namespace farm
{
    class Mouse :Mammal
    {
        public override void makeSound()
        {
            OutVoices += "*mouse noises*\n";
        }
        public override void eatFood(string food)
        {
            if (food != "Vegetable") { base.VeggieMeat(); }
        }

        public override void Output()
        {
            base.Output();
        }
        public override void OutputAll(Mammal animal)
        {
            base.OutputAll(animal);
        }
    }
}
