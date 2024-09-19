using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorobeinikovaDD.Sprint0.Task7.V0.Lib;

namespace Tyuiu.KorobeinikovaDD.Sprint0.Task7.V0
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Тема: Создание итогового решения по спринту            *");
            Console.WriteLine("* Задание #7                                             *");
            Console.WriteLine("* Вариант #0                                             *");
            Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1   *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                               *");
            Console.WriteLine("* Написать программу на С#, которая суммирует значения   *");
            Console.WriteLine("* двух одинаковых массивов по длине.                     *");
            Console.WriteLine("*                                                        *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                       *");
            Console.WriteLine("**********************************************************");


            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №7");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ",");

            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                             *");
            Console.WriteLine("**********************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("Сумма элментов массива ровна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ",");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Горим!");
            }
                Console.ReadKey();  
            
            
        }
    }  
}   

