// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число: ");
double number = Convert.ToInt32(Console.ReadLine());

double factorial = Factorial(number);
Console.WriteLine($"Количество цифр в числе {number} -> {factorial}");

double Factorial(double num)
{
    double fac = 1;
    for (double i = 1; i < num; i++)
    {
        checked
        {
            fac *= i; // fac = fac * i
        }
    }
    return fac;
}
