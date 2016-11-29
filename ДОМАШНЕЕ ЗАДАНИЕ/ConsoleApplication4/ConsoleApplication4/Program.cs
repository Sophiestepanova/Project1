using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string a;
            int buf;
            int ch = 0;
            a = Console.ReadLine();
            char[] b = a.ToCharArray();
            foreach (char l in b)
            {
                if (int.TryParse(Convert.ToString(l), out buf) == true)
                {
                    ch++;
                }
            }
            Console.WriteLine("Цифр :{0}", ch);
            Console.Read();
        }

    }

}