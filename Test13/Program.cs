// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

misst: Console.WriteLine("Введите День недельки: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 7 || number < 1)
{
    Console.WriteLine("Вам стоит попробовать снова: ");
    goto misst;
}
if(number == 6 || number == 7)
{
    Console.WriteLine("Вы уверены, что Вам нужен ВЫХОДНОЙ?");
    goto misst;
}
if(number == 5)
{
    Console.WriteLine("Это питница =)");
    goto misst;
}
if(number == 1 || number == 2 || number == 3)
{
    Console.WriteLine("ПИЗДУЙ РАБОТАТЬ!!!!!");
    goto misst;
}
if(number == 4)
{
    Console.WriteLine("ТЫ ЗАЕБАЛ!!! ПИЗДУЙ РАБОТАТЬ!!!!!");
    goto misst;
}