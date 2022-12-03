﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */

double[,] arrayRandom = new double[3, 4];
FillMatrixRandomDouble(arrayRandom);
WriteMatrix(arrayRandom);


void WriteMatrix(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}",array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void FillMatrixRandomDouble(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
        }
    }
}