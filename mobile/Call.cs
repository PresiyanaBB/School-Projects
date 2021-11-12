using System;
namespace mobile
{
    class Call
    {
        protected DateTime data { get; set; }
        protected double chasZapochvane { get; set; }
        protected double produljitelnost { get; set; }

        public static string[] callHistory = new string[50];
        public static double[] vremeCall = new double[50];
        public static double allCena;
        public static double maxVreme = 0;

        public static GSM[] allPhones = new GSM[100];      //ако е с готовите примери иначе да се маркира
        //public static GSM[] allPhones = new GSM[Program.numOfPhones+1];       //ако пишеш ръчно
        public static void OutputObajdaniq()
        {
            double vremeGovorene;
            for (int i = 0; Call.callHistory[i] != null; i++)
            {
                vremeGovorene = Call.vremeCall[i];
                var produljitelnost = TimeSpan.FromMinutes(vremeGovorene);
                int sec = produljitelnost.Seconds*100/60;
                int min = produljitelnost.Minutes;
                maxVreme = Math.Max(maxVreme, ( sec/100 + min));
                Console.WriteLine(Call.callHistory[i]);
                Console.WriteLine($"продължителност на разговори: {min} минути и {sec} секунди");
                Console.WriteLine($"сметката е: {allPhones[i].CallBill(allPhones[i],min + sec/100).ToString("F2")} лв.\n");
                allCena += allPhones[i].CallBill(allPhones[i], sec/100 + min);
            }
        }
    }
}
