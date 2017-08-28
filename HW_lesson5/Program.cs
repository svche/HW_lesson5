using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace HW_lessons5
    {
        class Program
        {
            static void Main(string[] args)
            {
                /* 5.7
    Составьте программу, котораЯ вычисляет произведение чисел от 1 до n. (n!)
    Значение n вводится с клавиатуры.*/
                /* 

                bool b = true;
                do
                {
                    Console.Write("Write number from 1 to 50: ");
                    ulong numInput = ulong.Parse(Console.ReadLine());

                    ulong mul = 1;

                    if (numInput < 50)
                    {
                        for (ulong i = 1; i < numInput; i++)
                        {
                            mul *= i;
                        }
                        Console.WriteLine("\nMultiplication of all numbers from 1 to {0} 
                                              is: {1:###,###}", numInput, mul);

                        b = false;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect number, try again!");
                    }
                } while (b);
                */

                /*Задача 5.8
    В банк на двадцати процентный вклад положили М гривен.
    Начисления происходят раз в год и добавляются к сумме вклада.
    Какой станет сумма вклада через N лет.*/
                /*
                            double P = 0.2;

                            Console.Write("How much money do you want to deposit? ");
                            double M = double.Parse(Console.ReadLine());

                            Console.Write("For how many years? ");
                            double Y = double.Parse(Console.ReadLine());


                            for (int i = 1; i <= Y; i++)
                            {
                                M = M + (M * P);

                                Console.WriteLine("In {0} year(s) you will have: {1}", i, M);
                             }
                  */

                /* Задача 5.9
    Даны натуральные числа от 1 до 50.
    Напечатать те из них, которые делятся на 3,
    но не делятся на 5. */
                /*
                           for (int i = 1; i <= 50; i++)
                            {
                                if (i % 3 == 0 && i % 5 != 0)
                                {
                                    Console.Write(i + " ");
                                }

                            }

                    */
                Console.ReadLine();
            }
        }
    }

}
    }
}
