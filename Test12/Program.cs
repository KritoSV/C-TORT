// Задача 13: Напишите программу, 
// которая выводит третью цифру 
// заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

metka: Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
    goto metka;
}
if (number < 100)
{
    Console.WriteLine("У Вас проблемы? Этого слишком мало.");
    goto metka;
}
while (number > 999)
{
    number /= 10;
    Console.WriteLine("Вы знаете слишком много, лишнее число изъято.");
}
int thirdDigit = (number % 10);
Console.WriteLine($"Третья цифра трехзначного числа {thirdDigit}");