// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

using System.Globalization;

Console.Clear();



int a = 4; int b = 3;
int min = 1; int max = 9;
int[,] array = new int[a, b];


Console.WriteLine("Повелитель, мы с гордостью представляем Вам Ваш двумерный массив ->");

ArrayMass();
PrintMass();

SumLine(array);


void ArrayMass()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }

    }
}

void PrintMass()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void SumLine(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] Mass = new int[arr.GetLength(0)];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Mass[i] += arr[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки в двумерном массиве -> {Mass[i]}");
    }
    int num = 0;
    for (int i = 1; i < Mass.Length; i++)
    {
        if (Mass[i] < Mass[num]) num = i;
            }
    Console.WriteLine($"Наименьшая строка -> {num + 1}");
}
