using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.BeketovVN.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Бекетов В. Н. | ИИПб-23-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Бекетов Виталий Николаевич | ИИПб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пусть k – целое от 1 до 365.                                            *");
            Console.WriteLine("* Присвоить целой переменной n значение 1,2,...,7 в зависимости от того,  *");
            Console.WriteLine("* на какой день недели (понедельник, вторник,..., воскресенье) приходится *");
            Console.WriteLine("*  k-й день невисокосного года, в котором 1 января – понедельник.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* K                                                                       *");
            Console.WriteLine("***************************************************************************");
         
            int k;
            

            Console.WriteLine("Введите X");
            k = Convert.ToInt32(Console.ReadLine());
            int res = ds.Calculate(k);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res == 1)
            {
                Console.WriteLine($"Понедельник {res} день недели, число {k}");
            }
            else if (res == 2)
            {
                Console.WriteLine($"Вторник {res} день недели, число {k}");
            }
            else if (res == 3)
            {
                Console.WriteLine($"Среда {res} день недели, число {k}");
            }
            else if (res == 4)
            {
                Console.WriteLine($"$Четверг {res} день недели, число {k}");
            }
            else if (res == 5)
            {
                Console.WriteLine($"$Пятница {res} день недели, число {k}");
            }
            else if (res == 6)
            {
                Console.WriteLine($"$Суббота {res} день недели, число {k}");
            }
            else if (res == 7)
            {
                Console.WriteLine($"$Воскресенье {res} день недели, число {k}");
            }
            Console.ReadLine();
        }
    }
}
