using System;
using System.Runtime.InteropServices;

namespace _4._2
{
    class Program
    {
        [DllImport("L4DLL.dll")]
        public static extern int Count(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("а = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = ");
            int b = Convert.ToInt32(Console.ReadLine());            
            int r = Count(a, b);
            Console.WriteLine("r = {0}", r);
        }
    }
}
