

void Circle(int r, int xo, int yo, int xa, int ya)
{
    Console.SetCursorPosition(xo, yo);
    Console.Write("*");
    while (xa != xo + r + 1)
    {
        ya = yo - (int)(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(xa - xo, 2)));
        Console.SetCursorPosition(xa, ya);
        Console.Write("*");
        //await Task.Delay(50);
        ya = yo + (int)(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(xa - xo, 2)));
        Console.SetCursorPosition(xa, ya);
        Console.Write("*");
        //await Task.Delay(50);
        xa++;
    }

    // Заполнение окружности
    xa = xo - r;
    int y1, y2;
    while (xa != xo + r + 1)
    {
        y1 = yo - (int)(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(xa - xo, 2)));
        y2 = yo + (int)(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(xa - xo, 2)));
        while (y1 != y2)
        {
            Console.SetCursorPosition(xa, y1);
            Console.Write("*");
            //await Task.Delay(10);
            y1++;
        }
        xa++;
    }
}

// Создание окружности
int r = 20; // Радиус окружности
int xo = 50, yo = 30, // Координаты центра окружности
    xa = xo - r, ya = yo; // Координаты начала построения (крайняя левая точка)


// Центральный
Circle(r, xo, yo, xa, ya);

// Левый

r = 10;
xo = 20; yo = 44;
xa = xo - r; ya = yo;

Circle(r, xo, yo, xa, ya);

r = 10;
xo = 25; yo = 44;
xa = xo - r; ya = yo;

Circle(r, xo, yo, xa, ya);

r = 10;
xo = 30; yo = 44;
xa = xo - r; ya = yo;

Circle(r, xo, yo, xa, ya);

r = 10;
xo = 35; yo = 44;
xa = xo - r; ya = yo;


Circle(r, xo, yo, xa, ya);

// Правый
r = 10;
xo = 65; yo = 44;
xa = xo - r; ya = yo;

Circle(r, xo, yo, xa, ya);

r = 10;
xo = 70; yo = 44;
xa = xo - r; ya = yo;

Circle(r, xo, yo, xa, ya);

r = 10;
xo = 75; yo = 44;
xa = xo - r; ya = yo;

Circle(r, xo, yo, xa, ya);

r = 10;
xo = 80; yo = 44;
xa = xo - r; ya = yo;

Circle(r, xo, yo, xa, ya);

int x = 50;
int i = 30 - r - 10;
while (i <= 30 - r - 5)
{
    Console.SetCursorPosition(x, i);
    Console.Write(" ");
    i++;
}

Console.SetCursorPosition(0, 60);


