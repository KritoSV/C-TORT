// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




int minimal = 1; int maximal = 5;
int[,] matrix1 = ArrayMass(2, 2, minimal, maximal);
Console.WriteLine();
int[,] matrix2 = ArrayMass(2, 2, minimal, maximal);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    Console.WriteLine();
    ArrayMass1(matrix1, matrix2);
}
else Console.WriteLine("Сорян СЭР!?! =(...дудум тсс...");





int[,] ArrayMass(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
    return array;
}



void ArrayMass1(int[,] matr1, int[,] matr2)
{
    int sum = 0;
    int[,] arr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                sum += matr1[i, k] * matr2[k, j];
            }
            arr[i, j] = sum;
            Console.Write($"{arr[i, j],2} ");
            sum = 0;
        }
        Console.WriteLine();
    }
}

