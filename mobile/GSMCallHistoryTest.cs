using System;
namespace mobile
{
    class GSMCallHistoryTest
    {
        public static GSM callTest = new GSM("SamsungA80", "Stefka", "A1", 2199.89);      //пример

        //public static GSM callTest = new GSM(GSMTest.inputPhonesThree[0], GSMTest.inputPhonesThree[1], GSMTest.inputPhonesThree[2], double.Parse(GSMTest.inputPhonesThree[3]));   //ако пишеш ръчно
        public static void AddCall()    //маркиране ако ще се въвеждат ръчно
        {
            GSM.callHistory[0] = callTest.Calls(callTest, DateTime.Now.Date, 12.40, 3.20);
            GSM.callHistory[1] = GSMTest.firstTest.Calls(GSMTest.firstTest, DateTime.Now.Date, 14.10, 5.40);
            GSM.callHistory[2] = GSMTest.secondTest.Calls(GSMTest.secondTest, DateTime.Now.Date, 16.80, 2.50);
        }
        //public static void AddCall()      //ако пишеш ръчно
        //{
        //    if (Program.numOfPhones == 1) GSM.callHistory[0] = callTest.Calls(callTest, DateTime.Now.Date, 12.40, 3.20);
        //    else if (Program.numOfPhones == 2)
        //    {
        //        GSM.callHistory[0] = callTest.Calls(callTest, DateTime.Now.Date, 12.40, 3.20);
        //        GSM.callHistory[1] = GSMTest.firstTest.Calls(GSMTest.firstTest, DateTime.Now.Date, 14.10, 5.60);
        //    }
        //    else
        //    {
        //        GSM.callHistory[0] = callTest.Calls(callTest, DateTime.Now.Date, 12.40, 3.20);
        //        GSM.callHistory[1] = GSMTest.firstTest.Calls(GSMTest.firstTest, DateTime.Now.Date, 14.10, 5.60);
        //        GSM.callHistory[2] = GSMTest.secondTest.Calls(GSMTest.secondTest, DateTime.Now.Date, 16.80, 2.50);
        //    }
        //}
    }
}
