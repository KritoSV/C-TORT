// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

metke: Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    number *= -1;
}
if(number < 100)
{
    Console.WriteLine("У вас проблемы?");
    Console.WriteLine("Попробуйте снова =)");
    goto metke;
}
if(number > 999)
{
    Console.WriteLine("У вас проблемы?");
    Console.WriteLine("Попробуйте снова =)");
    goto metke;
}
int secondDigit = (number / 10) % 10;

Console.WriteLine($"Второе число трёхзначного числа:{secondDigit}");