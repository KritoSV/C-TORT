// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно пАлИнДрОмоМ.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

metka: Console.WriteLine("Введите пятизначное числло: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 9999 || number > 99999)
{
    Console.WriteLine("У Вас проблемы с математикой?");
    goto metka;
}
PalindromeOrNot(number);
void PalindromeOrNot(int num)
{
    int reverseNum = 0;
    int x = num;
    while (x != 0)
    {
        reverseNum = reverseNum * 10 + x % 10;
        x /= 10;
    }

    if (num == reverseNum) Console.WriteLine("Число является полиндромом");
    else Console.WriteLine("Число не является полиндромом");
}
