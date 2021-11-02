namespace farm
{
    abstract class Animal
    {
        protected string animalName;
        protected double animalWeight;
        protected int foodEaten;
        protected string livingRegion;
        protected string OutVoices;
        
        public string animalType()
        {
            string ime = this.GetType().Name;   //взема името на класа
            return ime;
        }
        public virtual void makeSound()
        {
            ToString();
        }
        public abstract void eatFood(string food);
        public virtual void VeggieMeat()
        {
            OutVoices += animalType()+ " is not eating that type of food\n"; foodEaten = 0;
        }
        public virtual void Output()
        {
            OutVoices += animalType() + "[" + animalName + ", " + animalWeight + ", " + livingRegion + ", " + foodEaten + "]";
        }
        internal string breed;
    }
}
