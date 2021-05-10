using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 5
            double m;
            double h;
            Console.WriteLine("Введите Ваш вес: ");
            string str = Console.ReadLine();
            m = Convert.ToDouble(str);
            Console.WriteLine("Введите Ваш рост: ");
            string str1 = Console.ReadLine();
            h = Convert.ToDouble(str1);
            double I = m / (h * h);
            Console.WriteLine("{0} / {1} * {1} = {2} - Ваш индекс массы тела", m, h, I);
            Console.ReadLine();
            if  (I >= 18 && I <= 25)
                {
                Console.WriteLine($"{I} - Ваш индекс массы тела в норме");
                }
            else if (I <= 18)
            {
                Console.WriteLine($"{I} - У вас дефицит массы тела. Кушайте больше");
            }
            else
            {
                Console.WriteLine($"{I} - У вас ожирение. Вам срочно пора ходить в спортзал");
            }
            Console.ReadKey();
            #endregion

            #region Task 1 

            Console.WriteLine("Введите три целых числа");
            Console.WriteLine("Введите первое число :");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            var c = int.Parse(Console.ReadLine());
            int min;
            if (a < b)
            {
                if (a > c)
                {
                    min = c;
                } 
                else
                {
                    min = a;
                }
            } else
            {
                if ( b > c)
                {
                    min = c;
                } else
                {
                    min = b;
                }
            } 
            Console.WriteLine($"Минимальное число: {min}");
            Console.ReadKey();

            #endregion


            #region Task 3

            int f, counter = 0;

            do
            {
                Console.WriteLine("Выводим счетчик, пока не будет введен 0: ");
                f = int.Parse(Console.ReadLine());
                counter++;
            }

            while (f != 0);
            {
                Console.WriteLine("Количество попыток " + counter);
                Console.ReadKey();

            }

            #endregion

            #region Task 2

            Console.WriteLine("Введите любое число ");
            int u = int.Parse(Console.ReadLine());
            int count = 0;

            while (u != 0)
            {
                count++;
                u = u / 10;
            }
            Console.WriteLine("Количество цифр в числе = " + count);
            Console.ReadKey();
            #endregion

            Console.WriteLine("wwewкукуe");
        }
    }

       
}
