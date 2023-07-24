﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void count(double num1, double num2)
// {
//     if (num1 % num2 == 0)
//     {
//         Console.Write("Кратно");
//     }
//     else
//     {
//         System.Console.WriteLine($"Не кратно. Выводим остаток {num1 % num2} ");
//     }
// }
// count(num1, num2);

// решение 2
int Remains(int firstNum, int secondNum)
{
    int remains = firstNum % secondNum;
    return remains;
}

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int x = Remains(a, b);
if (x == 0)
    Console.WriteLine($"Число a кратно b");
else
    Console.WriteLine($"Число a не кратно b. Остаток равен {x}");