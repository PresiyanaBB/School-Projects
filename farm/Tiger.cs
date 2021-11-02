namespace farm
{
    class Tiger:Felime
    {
        public override void makeSound()
        {
            OutVoices += "*tiger noises*\n";
        }
        public override void eatFood(string food)
        {
            if (food != "Meat") { base.VeggieMeat(); }
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
