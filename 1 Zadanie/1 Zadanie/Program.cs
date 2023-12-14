using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
 * и возвращает значение этого элемента или же указание, что такого элемента нет.*/

namespace _1_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = GenerateRandom2DArray(10, 10);
            Print2DArray(array);

            Console.WriteLine("Введите номер строки: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер колонки: ");
            int col = Convert.ToInt32(Console.ReadLine());

            string elementValue = GetElemetValue(array, row, col);
            Console.WriteLine($"Значение элемента ({row}, {col}): {elementValue}");
        }

        //функция рандомного заполнения массива

        static int[,] GenerateRandom2DArray(int rows, int cols)
        {
            int[,] randomArray = new int[rows, cols];
            Random rnd = new Random();
            for(int i =0; i<rows; i++)
            {
                for(int j =0; j<cols; j++)
                {
                    randomArray[i, j] = rnd.Next(10, 100);
                }
            }
            return randomArray;
        }

        // функция поиска элемента по номеру строки и колонки
        static string GetElemetValue(int[,] array, int x, int y)
        {
            if(x>=0&& x<array.GetLength(0)&& y >= 0 && y < array.GetLength(1))
            {
                return array[x, y].ToString();
            }
            else
            {
                return "Такого элемента нет.";
            }

        }

        //функция вывода массива
        static void Print2DArray (int[,] array)
        {
            for(int i =0; i<array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+ "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
