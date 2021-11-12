namespace mobile
{
    class Battery
    {
        protected string model;
        protected double idleTime, hoursTalk;
        public virtual string BatteryInfo()
        {
            return $"{model}  |  {idleTime}  |  {hoursTalk}";
        }
        public Battery(string modell,double idleTimee, double hoursTalkk)
        { 
            model = modell;
            idleTime = idleTimee;
            hoursTalk = hoursTalkk;
        }
        enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd,
            LiPo
        }
    }
}
