using System;
namespace mobile
{
    class GSM:Call
    {
        protected string proizvoditel { get; set; } 
        protected string sobstvenik { get; set; }
        protected double cena { get; set; }
        protected static int countCalls=0;
        protected string model { get; set; }
        public static GSM iPhone = new GSM("iPhone11", "Mitko", "Apple", 3400.60);
        public GSM(string modell,string sobstvenikk,string proizvoditell,double cenaa)
        {
            
            model = modell;
            sobstvenik = sobstvenikk;
            proizvoditel = proizvoditell;
            cena = cenaa;
        }

        public virtual string Calls(GSM phone,DateTime d,double nachalo,double prod)
        {
            string text;
            phone.chasZapochvane = nachalo;
            phone.produljitelnost = prod;
            phone.data = d;
            text =$"модел: {phone.model} | собственик: {phone.sobstvenik} |  дата: {phone.data.ToShortDateString()} | начало: {phone.chasZapochvane.ToString("F2")} ч. | продължителност: {phone.produljitelnost.ToString("F2")} ч.";
            vremeCall[countCalls] = phone.produljitelnost;
            countCalls++;
            return text;
        }
        public double CallBill(GSM phone, double prod)
        {
            phone.produljitelnost = prod;
            return phone.produljitelnost * 0.37;
        }
        public string GSMInfo(GSM phone)
        {
            return $"{phone.model,-20}  |  {phone.sobstvenik,-12}  |  {phone.proizvoditel,-12}  |  {phone.cena.ToString("F2")} лв.";
        }
    }
}
