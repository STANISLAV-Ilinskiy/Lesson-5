using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

namespace _3_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = GenerateRandom2DArray(5, 5);
            Console.WriteLine("\t Исходный массив: ");
            Console.WriteLine();

            Print2DArray(array);

            Console.WriteLine();

            var result = FindRowWithMinSum(array);

            Console.WriteLine($"Строка с наименьшей суммой элементов: {result}");

            Console.WriteLine();
        }

        // Функция рандомного заполнения массива
        static int[,] GenerateRandom2DArray(int row, int col)
        {
            int[,] randomArray = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    randomArray[i, j] = rnd.Next(10, 100);
                }
            }
            return randomArray;
        }

        //Функция вывода массива

        static void Print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //Функция нахождения строки с наименьшей суммой элементов

        static int FindRowWithMinSum(int[,] array)
        {
            int minSum = int.MaxValue;
            int rowIndex = -1;

            for(int i=0; i<array.GetLength(0); i++)
            {
                int sum = 0;
                for(int j=0; j<array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }

                if (sum < minSum)
                {
                    minSum = sum;
                    rowIndex = i;
                }
            }

            return rowIndex;
        }
    }
       
}
