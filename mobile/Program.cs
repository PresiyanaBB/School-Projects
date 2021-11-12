using System;
namespace mobile
{
    class Program
    {
        //всички маркировки са ако искаме да си пишем телефоните наръка

        //public static int numOfPhones;   //ако пишеш ръчно
        public static void Main(string[] args)
        {
            string tire = "-------------------------------------------------------------------------------------------\n";

            Console.WriteLine("Телефони:");
            //Console.Write("Колко телефона искате? ");         //ако пишеш ръчно
            //numOfPhones = int.Parse(Console.ReadLine());      //ако пишеш ръчно
            GSMTest.AddPhones();

            Console.WriteLine(tire);

            GSMTest.OutTests();
            GSMCallHistoryTest.AddCall();

            Console.WriteLine(tire);

            Console.WriteLine("Обаждания:");
            Call.OutputObajdaniq();

            Console.WriteLine(tire);

            Console.WriteLine($"{Math.Round(Call.allCena,2).ToString("F2")} лв. обща сметка");
            Console.WriteLine($"{Math.Round(Call.allCena - Call.maxVreme*0.37,2)} лв. обща сметка без най-голямата");
            Console.ReadLine();
        }
    }
}
