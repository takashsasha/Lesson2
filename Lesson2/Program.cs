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

            string name = "        ООО \"Образец\"          ";
            string KKM = "000012345";
            DateTime dateAndTime = new DateTime(2011, 10, 11, 11, 18, 22);
            string INN = "001234567890";
            string numCheque = "#2222";
            string kefir = "=25.00";
            string smetana = "=55.00";
            string sum = "=80.00";
            string nal = "100";
            string surrender = "20";
            string eclz = "1234567890";

            Console.WriteLine($"+---------------------------------+");
            Console.WriteLine($"|                                 |");
            Console.WriteLine($"|{name}  |");
            Console.WriteLine($"|ККМ {KKM}   ИНН {INN} |");
            Console.WriteLine($"|{dateAndTime}      Кассир 1|");
            Console.WriteLine($"|ПРОДАЖА                     {numCheque}|");
            Console.WriteLine($"|Кефир                      {kefir}|");
            Console.WriteLine($"|Сметана                    {smetana}|");
            Console.WriteLine($"|Всего                      {sum}|");
            Console.WriteLine($"|Наличными                     {nal}|");
            Console.WriteLine($"|Сдача                          {surrender}|");
            Console.WriteLine($"+---------------------------------+");
            Console.WriteLine($"|ЭКЛЗ {eclz}                  |");
            Console.WriteLine($"+---------------------------------+");

            Console.ReadKey();
        }
    }
}
