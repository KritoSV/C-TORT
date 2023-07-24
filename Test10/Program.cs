﻿// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int a = new Random().Next(100, 1000);
// Console.WriteLine(a);
// int firstDigit = a / 100;
// int secondDigit = a % 10;
// int b = 10 * firstDigit + secondDigit;
// Console.WriteLine(b);

// Console.WriteLine($"Ваше число: {firstDigit}{secondDigit}");


// с помощью функции решение 2
int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int b = 10 * firstDigit + secondDigit;
    return b;
}

int a = new Random().Next(100, 1000);
Console.WriteLine(a);

int b = DeleteSecondDigit(a);
Console.WriteLine(b);