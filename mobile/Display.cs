namespace mobile
{
    class Display
    {
        protected double[,] golemina;
        protected string cvetove;
        public virtual string DisplayInfo()
        {
            return $"{golemina.ToString()}  |  {cvetove} ";
        }
        public Display(double[,] goleminaa, string cvetovee)
        {
            golemina = goleminaa;
            cvetove = cvetovee;
        }
    }
}
