// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
SquareTable(number);

void SquareTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int square = i * i;
        Console.WriteLine($"{i, 3}     {square, 5}");
    }
} 


// Console.WriteLine("Введите целое натуральное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0)
// SquareNumber(number);

// void SquareNumber(int numb)
// {
//     int count = 1;
//     while(count <= numb)
//     {
//         Console.WriteLine($"{count} {count * count}");
//         count++;
//     }

// }