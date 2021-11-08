using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalKrai
{
    class Surgeon : Hworker
    {
        public string title;
        public int SurCount;
        public override double Salary => SurCount * 3 + 1000;
        protected override void OutInfo(int i)
        {
            Console.WriteLine($"{i + 1,3}:{ime} | Стаж: {staj,6} | Брой пациенти: {pacienti,6} | Заплата: {Salary,6} | Длъжност: {GetType().ToString().Substring(9)} | Титла: {title} | Операции: {SurCount}");
            Console.WriteLine();
        }
    }
}
