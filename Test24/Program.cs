// Задача 25: 
// Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
double number1 = Convert.ToInt32(Console.ReadLine());

metka: Console.WriteLine("Введите степень первого числа: ");
double number2 = Convert.ToInt32(Console.ReadLine());

if (number2 <= 0)
{
    Console.WriteLine("Некорректная степень числа.");
    goto metka;
}


PowerNumbers(number1, number2);
double PowerNumbers(double a, double pow)
{
    double num = 1;
    for (double i = 0; i < pow; i++)
    {
        checked
        {
            num *= a;
        }

    }
    return num;
}
Console.WriteLine($"Степень первого числа: {PowerNumbers(number1, number2)}");
