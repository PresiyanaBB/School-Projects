using System;
namespace mobile
{
    class GSMTest
    {
        public static GSM firstTest = new GSM("iPhone8plus", "Gosho", "Apple", 3399.99);               // пример
        public static GSM secondTest = new GSM("SamsungGalaxyS10", "Toshko", "A1", 2999.50);          // пример

        //public static string[] inputPhones = Console.ReadLine().Split();                      //ако пишеш ръчно
        //public static string[] inputPhonesTwo = Console.ReadLine().Split();                   //ако пишеш ръчно
        //public static string[] inputPhonesThree = Console.ReadLine().Split();                 //ако пишеш ръчно
        //public static GSM firstTest = new GSM(inputPhones[0], inputPhones[1], inputPhones[2], double.Parse(inputPhones[3]));   //ако пишеш ръчно
        //public static GSM secondTest = new GSM(inputPhonesTwo[0], inputPhonesTwo[1], inputPhonesTwo[2], double.Parse(inputPhonesTwo[3]));   //ако пишеш ръчно

        public static void AddPhones()         //ако е с готови примери иначе да се марккира
        {
            Call.allPhones[0] = firstTest;
            Call.allPhones[1] = secondTest;
            Call.allPhones[2] = (GSM)GSMCallHistoryTest.callTest;
            Call.allPhones[3] = GSM.iPhone;
        }

        //public static void AddPhones()            //ако пишеш ръчно
        //{
        //    if (Program.numOfPhones == 1) { Call.allPhones[0] = firstTest; Call.allPhones[1] = firstTest; }
        //    else if (Program.numOfPhones == 2) { Call.allPhones[0] = firstTest; Call.allPhones[1] = secondTest; Call.allPhones[2] = secondTest; }
        //    else if (Program.numOfPhones == 3) { Call.allPhones[0] = firstTest; Call.allPhones[1] = secondTest; Call.allPhones[2] = GSM.iPhone; Call.allPhones[3] = (GSM)GSMCallHistoryTest.callTest; }
        //    else Console.WriteLine("Нямаме толкова телефони");
        //}
        public static void OutTests()
        {
            string OutAllTests = "";
            for (int i = 0;Call.allPhones[i] != null; i++)
            {
                OutAllTests += Call.allPhones[i].GSMInfo(Call.allPhones[i]) + "\n";
            }
            Console.WriteLine(OutAllTests);
        }
    }
}
