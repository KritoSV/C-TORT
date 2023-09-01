// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] matrix1 = ArrayMass(2, 2, 2);
PrintArrayMass(matrix1);



int[,,] ArrayMass(int m, int n, int d)
{
    int count = 10;
    int[,,] array = new int[m, n, d];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                
                    array[i, j, k] = count;
                    count += 7;
            }
        }
    }
    return array;
}


void PrintArrayMass(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],2} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}









            //    bool second;
            //     do
            //     {
            //         second = false;
            //         array[i, j, k] = new Random().Next(min, max + 1);
            //         for (int l = 0; l <= j; l++)
            //         {
            //             for (int o = 0; o <= k; o++)
            //             {
            //                 for (int p = 0; p < i; p++)
            //                 {
            //                     if (array[k, i, j] == array[l, o, p])
            //                     {
            //                         second = true;
            //                     }
            //                 }
            //             }
            //         }
            //     } while (second);