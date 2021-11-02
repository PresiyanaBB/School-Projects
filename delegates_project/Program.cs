using System;

namespace delegates_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1wi opit";
            Action<string> del = Method1;
            del(a);

        }
        public static void Method1(string pechat)
        {
            Console.WriteLine(pechat);
        }
    }
}
