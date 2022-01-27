using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число которое мы проверим на четность");
            var num = Convert.ToDouble(Console.ReadLine());
            if ((num % 2) != 0)
            {
                Console.WriteLine("Введенное число не четное");
            }
            else
            {
                Console.WriteLine("Введенное число четное");
            }
            Console.ReadKey();
        }
    }
}