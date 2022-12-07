// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9


Console.WriteLine("Введите количество строк двумерного массива:");
int r = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива:");
int c = int.Parse(Console.ReadLine());

int[,] array = new int[r, c];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 100);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}

Console.WriteLine("введите номер строки");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int b = int.Parse(Console.ReadLine());

if (a > array.GetLength(0) || b > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Элемент массива по введенным координатам = : {array[a-1,b-1]}");
}
