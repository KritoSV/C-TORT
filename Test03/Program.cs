// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите чётное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number % 2 == 0)
{
    Console.WriteLine($"Поздравляем, Вы ввели чётное число: {number}");
}
while (number % 2 == 1)
{
    Console.WriteLine("Поздравляем, Вы не знаете чётных чисел! =)");
    Console.Write("Попробуйте снова :");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Поздравляем, Вы молодец. чётное число: {number}");