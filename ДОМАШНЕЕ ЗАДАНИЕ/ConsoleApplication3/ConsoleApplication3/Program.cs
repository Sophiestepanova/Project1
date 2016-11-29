using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            int buf;
            int k = int.Parse(Console.ReadLine());
            string[] array = new string[k];
            for (int i = 0; i < k; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.Write("Массив до замены: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0}", array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out buf) == true)
                {
                    array[i] = "$";
                }
            }
            Console.Write("\r\nМассив после замены: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0}", array[i]);
            }
            Console.Read();
        }
    }
}
