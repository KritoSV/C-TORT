Console.Clear();



Console.WriteLine("Здравствуйте пользователь! Давайте поиграем в математику.");


int min = 1;
int max = 20;


int a = new Random().Next(min, max);
int b = new Random().Next(min, max);
int sum = 0;


Console.Write($"Напишите сумму {a} + {b} -> ");
int userNum = int.Parse(Console.ReadLine()!);

sum = SumNumbers(a, b);
UserSumNumber(userNum, sum);


void UserSumNumber(int un, int s)
{
    if (un == s)
    {
        Console.WriteLine($"Молодец, {userNum} это правильный ответ.");
    }
    else
    {
        Console.WriteLine($"{userNum} это не правильный ответ. правильный ответ -> {sum}");
    }
}

int SumNumbers(int x, int y)
{
    int summa = x + y;
    return summa;
}

