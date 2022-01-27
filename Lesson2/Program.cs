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
           double sred;
            Console.WriteLine("Введите минимальную температуру за сутки");
            var min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            var max = Convert.ToDouble(Console.ReadLine());
            sred = (min + max) / 2;
            Console.WriteLine($"Среднесуточная температура = {sred}");
            Console.ReadKey();
        }
    }
}
