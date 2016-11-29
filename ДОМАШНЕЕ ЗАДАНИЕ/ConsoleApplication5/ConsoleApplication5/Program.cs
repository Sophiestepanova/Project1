using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int size1, size2, ch = 0;
            Console.Write("Введите размер первого массива:");
            size1 = int.Parse(Console.ReadLine());
            Console.Write("Введите размер второго массива:");
            size2 = int.Parse(Console.ReadLine());
            int[] array1 = new int[size1];
            int[] array2 = new int[size2];
            int[] array3 = new int[size1 + size2];
            for (int i = 0; i < size1; i++, ch++)
            {
                Console.Write("Введите элемент номер {0} первого массива :", i + 1);
                array1[i] = int.Parse(Console.ReadLine());
                array3[ch] = array1[i];
            }
            Console.WriteLine("");
            for (int i = 0; i < size2; i++, ch++)
            {
                Console.Write("Введите элемент номер {0} второго массива :", i + 1);
                array2[i] = int.Parse(Console.ReadLine());
                array3[ch] = array2[i];
            }
            Console.Write("Первый массив:");
            foreach (int i in array1)
            {
                Console.Write(" {0}", i);
            }
            Console.Write("\r\nВторой массив:");
            foreach (int i in array2)
            {
                Console.Write(" {0}", i);
            }
            Console.Write("\r\nМассив из двух массивов:");
            foreach (int i in array3)
            {
                Console.Write(" {0}", i);
            }
            Console.Read();
        }
    }
}

