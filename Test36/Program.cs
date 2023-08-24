// Задача 47. 
// Задайте двумерный массив 
// размером m × n, заполненный 
// случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Прошу, ваш массив -> ");
Console.Clear();

int m = 3; int n = 4;


double min = -10;
double max = 10;
double[,] MassNum = new double[m, n];
Console.WriteLine("Ваш рандомный массив, Сэр! -> ");
void ProPry()
{
    for (int i = 0; i < MassNum.GetLength(0); i++)
    {
        for (int j = 0; j < MassNum.GetLength(1); j++)
        {
            MassNum[i, j] = new Random().NextDouble() * (max - min)+ min;
            MassNum[i, j] = Math.Round(MassNum[i, j], 2);
            Console.Write($"{MassNum[i, j], 6} ");

        }
        Console.WriteLine();
    }
}

ProPry();