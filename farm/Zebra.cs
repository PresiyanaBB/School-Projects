namespace farm
{
    class Zebra:Mammal
    {
        public override void makeSound()
        {
            OutVoices += "*zebra noises*\n";
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
