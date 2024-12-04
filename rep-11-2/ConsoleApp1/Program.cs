using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Поменять местами содержимое двух строковых переменных
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str1 = "Это первая строка";
            string str2 = "Это вторая строка";
            Console.WriteLine($"Строки до обмена {str1}\t{str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"Строки после обмена {str1}\t{str2}");
            Console.ReadLine();
        }
        public static void Swap(ref string str1, ref string str2)
        {
            string p = str1;
            str1 = str2;
            str2 = p;
        }
    }
}
