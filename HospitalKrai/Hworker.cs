using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalKrai
{
    abstract class Hworker
    {
        public static List<Hworker>helth = new List<Hworker>();
        protected string ime;
        protected int staj;
        protected int pacienti;
        public abstract double Salary { get; }
        protected static string usInput(string a)
        {
            Console.Write(a);
            return Console.ReadLine();
        }
        protected static int UserInputInt(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        protected virtual void OutInfo(int i)
        {
            Console.WriteLine($"{i + 1,3}:{ime} | Стаж: {staj,6} | Брой пациенти: {pacienti,6} | Заплата: {Salary,6} | Длъжност: {GetType().ToString().Substring(9)}");
            Console.WriteLine();
        }
        static void OutAll()
        {
            for (int i = 0; i < helth.Count; i++)
            {
                helth[i].OutInfo(i);
            }
        }
        static void AddHworker(Hworker h)
        {
            int a = UserInputInt("1 - Dentist, 2 - Nurse, 3 - Surgeon, 4 - Doctor: ");
            Console.WriteLine();
            switch (a)
            {
                case 1:
                    h = new Dentist();
                    InputWorker(h);
                    break;
                case 2:
                    h = new Nurse();
                    InputWorker(h);
                    break;
                case 3:
                    var n = new Surgeon();
                    InputWorker(n);
                    n.title = usInput("titla: ");
                    n.SurCount = int.Parse(usInput("br operacii: "));
                    h = n;
                    break;
                case 4:
                    h = new Doctor();
                    InputWorker(h);
                    break;
            }
            Console.WriteLine();
            helth.Add(h);
        }
        static void ChangeInfo(string Name)
        {
            int b = 0;
            for (int i = 0; i < helth.Count; i++)
            {
                if (helth[i].ime == Name) { b = i; break; }
            }
            int a = UserInputInt("Кое искаш да промениш? 1 - Стаж, 2 - Брой пациенти : ");
            switch (a)
            {
                case 1:
                    helth[b].staj = UserInputInt("Въведи нов стаж:");
                    break;
                case 2:
                    helth[b].pacienti = UserInputInt("Въведи нов брой пациенти: ");
                    break;
            }
        }
        static void InputWorker(Hworker a)
        {
            a.ime = usInput("Въведи име: ");
            a.staj = int.Parse(usInput("Въведи стаж: "));
            a.pacienti = int.Parse(usInput("Въведи брой пациенти: "));
        }
        static void AvgSalary()
        {
            double a = 0, counter = 0;
            for (int i = 0; i < helth.Count; i++)
            {
                a += helth[i].Salary;
                counter++;
            }
            Console.WriteLine($"Средната заплата на всички работници е: {(a / counter):F2}");
        }
        static void MaxSalary()
        {
            double a = 0;
            int b = 0;
            a = helth[0].Salary;
            for (int i = 0; i < helth.Count; i++)
            {
                if (a < helth[i].Salary)
                {
                    a = helth[i].Salary;
                    b = i;
                }
            }
            Console.WriteLine($"Най високата заплата е на {helth[b].ime}: {a}лв.");
        }
        static void InitializeHospital()
        {
            int n;
            n = UserInputInt("Въведи брой здравни работници: ");
            for (int i = 0; i < n; i++)
            {
                Hworker hw = null;
                AddHworker(hw);
                helth[i].OutInfo(i);
            }
        }
        public static void RunHospital()
        {
            InitializeHospital();
            while (true)
            {
                int a = UserInputInt("1 - Нов работник, 2 - Списък на всички работници, 3 - Средна заплата на работниците, \n " +
                                     "4 - Работник с най-голяма заплата, 5 - Корекция по име: ");
                Console.WriteLine();
                switch (a)
                {
                    case 1:
                        Hworker.AddHworker(null);
                        break;
                    case 2:
                        OutAll();
                        break;
                    case 3:
                        AvgSalary();
                        break;
                    case 4:
                        MaxSalary();
                        break;
                    case 5:
                        ChangeInfo(usInput("Въведи име на работник: "));
                        break;
                }
                if (a < 1 || a > 5) break;
            }
        }
    }
}


