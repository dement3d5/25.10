using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число b");
            int.TryParse(Console.ReadLine(), out int b);
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            if (b>a)
                Console.WriteLine("Много");
            else
                if (b<a)
                Console.WriteLine("Мало");
            else
                Console.WriteLine("Угадал");
            Console.ReadLine();
            

        }
    }
}
