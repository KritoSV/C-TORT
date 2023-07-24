// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите чему равно число N= : ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (number < 2)
{
    Console.WriteLine("К сожалению вы ввели слишком маленькое число =(");
    Console.WriteLine("Порпобуйте снова =)");
    Console.Write("Число N = : ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (count <= number)
{
    if (count % 2 == 0)
        System.Console.Write(count + " ");
    count++;
}


Console.WriteLine();

//Finished programm!