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
            
            Console.WriteLine("Введите порядковый номер текущего месяца");
            var dayOfWeek = Convert.ToInt32(Console.ReadLine());
            if ((dayOfWeek <= 0) || (dayOfWeek >= 13))
            {
                Console.WriteLine("Такого месяца нету");
            }
            string dayTitle = "";
            switch (dayOfWeek)
            {

                case 1:
                    dayTitle = "Январь";
                    break;
                case 2:
                    dayTitle = "Февраль";
                    break;
                case 3:
                    dayTitle = "Март";
                    break;
                case 4:
                    dayTitle = "Апрель";
                    break;
                case 5:
                    dayTitle = "Май";
                    break;
                case 6:
                    dayTitle = "Июнь";
                    break;
                case 7:
                    dayTitle = "Июль";
                    break;
                case 8:
                    dayTitle = "Август";
                    break;
                case 9:
                    dayTitle = "Сентябрь";
                    break;
                case 10:
                    dayTitle = "Октябрь";
                    break;
                case 11:
                    dayTitle = "Ноябрь";
                    break;
                case 12:
                    dayTitle = "Декабрь";
                    break;
            }

            Console.WriteLine(dayTitle);

            Console.ReadKey();
        }
    }
}
