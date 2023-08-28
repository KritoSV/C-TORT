// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой 
// строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int a = 5; int b = 14;
int min = 0; int max = 10;
int[,] array = new int[a, b];


Console.WriteLine("Повелитель, мы с гордостью представляем Вам Ваш двухмерный массив     ->");

ArrayMass();
PrintMass();
AbsArray(array);

Console.WriteLine("Повелитель, Ваш массив слегка не впорядке. Мы аккуратно его перебрали ->");
PrintMass();

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


void AbsArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int o = 0; o < arr.GetLength(1) - j - 1; o++)
            {
                if (arr[i, o] < arr[i, o + 1])
                {
                    (arr[i, o], arr[i, o + 1]) = (arr[i, o + 1], arr[i, o]);
                }
            }
        }
    }
}