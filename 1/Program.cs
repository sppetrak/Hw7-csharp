﻿// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите количество строк двумерного массива:");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива:");
int c = Convert.ToInt32(Console.ReadLine());

double[,] doubleArray = new double[s, c];

void PrintArray(double[,] array)
{
    for (int i = 0; i < s; i++)
    {
        for (int j = 0; j < c; j++)
        { Console.Write($"{array[i, j]}   "); }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
FillArray(doubleArray);
Console.WriteLine();
PrintArray(doubleArray);