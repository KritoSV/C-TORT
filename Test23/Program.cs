// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

FillArr(array);
PrintArr(array);

void FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


// int[] array = new int[8]; // 0 1 2 3 4 5 6 7 

// int[] array1 = { 5, 6, 7, 9 };
// int[] array2 = new int[] { 5, 6, 7, 9 };
// int[] array3 = new int[8] { 5, 6, 7, 9, 2, 1, 8 };

// var array4 = new int[8];
// { 5, 6, 7, 9 };
// var rnd = new Random();  //  var rnd = 5 / 6; - Так нельзя!!!!



// array[4] = 454;
// Console.WriteLine(array[4]);

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
//     Console.Write(array[i] + " ");
// }