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
        /// Составить программу, в результате которой величина а меняется значением с величиной b, а величина c — с величиной d
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Vvod("a=");
            int b = Vvod("b=");
            int c = Vvod("c=");
            int d = Vvod("d=");
            Console.WriteLine($"Строки до обмена {a}\t{b}\t{c}\t{d}");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.WriteLine($"Строки после обмена {a}\t{b}\t{c}\t{d}");
            Console.ReadLine();
        }
        public static int Vvod(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Swap(ref int x,ref int y)
        {
            int p = x;
            x = y;
            y = p;
        }
    }
}
