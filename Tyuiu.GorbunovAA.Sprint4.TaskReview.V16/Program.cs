using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorbunovAA.Sprint4.TaskReview.V16.Lib;

namespace Tyuiu.GorbunovAA.Sprint4.TaskReview.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "382976421897948";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* TaskReview                                                            *");
            Console.WriteLine("* Вариант 16                                                            *");
            Console.WriteLine("* Выполнил: Горбунов Александр Александрович / ИИПб-23-3                *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Вывести произведение четных чисел исходной строки                     *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine(" 382976421897948");
            int index = 0;
            Console.WriteLine("\nМассив:");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" Произведение всех четных чисел - " + ds.Calculate(rows, columns, str));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
