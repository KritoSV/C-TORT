﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine()!);

// решение без функции
// if (number % 7 == 0 && number % 23 == 0) //&& count2
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }

// решение с функциями
bool Multiplicity(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

bool result = Multiplicity(number);

Console.WriteLine(result ? "Да" : "Нет");