// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("- Эй ты?! Да, да, ТЫ!! Отдаю числа, не дорого!!!! Сколько чисел тебе надо?: ");
Console.Write("Я хочу, что бы чисел было: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[count];

void Arraynumbers()
{
    Console.WriteLine("Молодец, теперь выбери числа, которые тебе понравились:");
    for (int i = 0; i < count; i++)
    {
        if (i > 0)
        {
            Console.Write("Ещё: ");
        }
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountNum()
{
    int schetcheck = 0;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] > 0)
        {
            schetcheck ++;
        }
    }
    return schetcheck;
}

Arraynumbers();
Console.WriteLine($"ПС! Парень!! Забирай свои числа [{string.Join("; ", arr)}], только не пались. Бери быстрее, их тут: {CountNum()}");
