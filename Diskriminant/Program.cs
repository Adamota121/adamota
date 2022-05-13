using System;

namespace Diskriminant
{
    internal class Program
    {
        public static decimal Main()
        {
            Console.WriteLine("Введите число a");
            decimal a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            decimal b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            decimal c = Convert.ToInt32(Console.ReadLine());

            return Disk();
        }

        public static decimal Disk()
        {
            decimal D = b**2 - 4 * a * c;
            return D;
        }
    }
}
