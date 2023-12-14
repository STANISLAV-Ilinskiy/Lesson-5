using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

namespace _2_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = GenerateRandom2DArray(10, 10);
            Console.WriteLine("\t Исходный массив: ");
            Console.WriteLine();

            Print2DArray(array);

            Console.WriteLine();

            SwapFirstAndLastRowsArray(array);

            Console.WriteLine("\t Измененый массив: ");
            Console.WriteLine(); 

            Print2DArray(array);

        }

        // Функция рандомного заполнения массива
        static int[,] GenerateRandom2DArray(int row, int col)
        {
            int[,] randomArray = new int[row, col];
            Random rnd = new Random();
            for(int i = 0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    randomArray[i, j] = rnd.Next(10, 100);
                }
            }
            return randomArray;
        }

        //Функция вывода массива

        static void Print2DArray(int[,] array)
        {
            for(int i=0; i<array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //Функция изменения местами первой и последней строки массива
         static void SwapFirstAndLastRowsArray(int[,] array)
        {
            int rowCount = array.GetLength(0);
            int colCount = array.GetLength(1);

            if (rowCount > 1)
            {
                for (int i = 0; i < colCount; i++)
                {
                    int temp = array[0, i];
                    array[0, i] = array[rowCount - 1, i];
                    array[rowCount - 1, i] = temp;
                }
                
            }
        }
    }
}
