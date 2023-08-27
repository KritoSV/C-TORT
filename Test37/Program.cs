// Задача 50. 
// Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.Clear();

int m = 5; int n = 5;
int min = 1; int max = 10;
int gix = 1;

Console.WriteLine($"Пользователь, мы с гордостью представляем Вам наш массив ->");

int[,] MassNum = new int[m, n];

ProPry();


Console.WriteLine("Пользователь, укажите нужную строку: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пользователь, укажите нужный столбец: ");
int b = Convert.ToInt32(Console.ReadLine());

int? result = ReversPoint(a, b, MassNum);

if (result == null)
{
    Console.WriteLine($"Данной позиции в массиве не найдено.");
}
else
{
    Console.WriteLine($"Ваша точка точка {result} в массиве расположеная по координатам {a} и {b}");
}

void ProPry()
{
    for (int i = 0; i < MassNum.GetLength(0); i++)
    {
        for (int j = 0; j < MassNum.GetLength(1); j++)
        {
            MassNum[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{MassNum[i, j],6} ");
        }
        Console.WriteLine();
    }
}

int? ReversPoint(int x, int y, int[,] Mass)
{
    if (x > Mass.GetLength(0) && y > Mass.GetLength(1))
    {
        return null;
    }
    else
    {
        gix = Mass[x - 1, y - 1];
        return gix;
    }

}
