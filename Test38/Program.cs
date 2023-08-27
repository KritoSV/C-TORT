// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое 
// каждого столбца: 4,6; 5,6; 3,6; 3.

using System.Diagnostics.CodeAnalysis;

Console.Clear();

int m = 4; int n = 4;


int min = 1;
int max = 9;
int[,] MassNum = new int[m, n];
Console.WriteLine("Ваш рандомный массив, Сэр! -> ");

ProPry();

var ArrayNum = SumStolbik(MassNum);

for (int i = 0; i < ArrayNum.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца рвано: {ArrayNum[i]}");
    }

void ProPry()
{
    for (int i = 0; i < MassNum.GetLength(0); i++)
    {
        for (int j = 0; j < MassNum.GetLength(1); j++)
        {
            MassNum[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{MassNum[i, j],4} ");
        }
        Console.WriteLine();
    }
}



double[] SumStolbik(int[,] MassArr)
{
    double sum = 0;
    double[] Array = new double[MassNum.GetLength(1)];

    for (int j = 0; j < MassNum.GetLength(1); j++)
    {
        for (int i = 0; i < MassNum.GetLength(0); i++)
        {
            sum += MassArr[i, j];
        }
        Array[j] = sum / MassNum.GetLength(0);
        sum = 0;
    }
    return Array;
}

