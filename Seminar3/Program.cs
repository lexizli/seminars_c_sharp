// Напишите программулечку, которая принимает на вход координаты точки
// и сообщает, в каком квадранте находится точка

int WhatQuadrant(double abscissa, double ordinate)
{
    if (abscissa > 0) return ordinate > 0 ? 1 : 4;
    else return ordinate > 0 ? 2 : 3;;
}
Console.Clear();
Console.Write("Input x: ");
double absc1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y: ");
double ordi1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(WhatQuadrant(absc1,ordi1));



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
void Square(int number)
{
    int step = 0;
    for (step = 1; step <= number; step++ )
    {
        Console.WriteLine(Math.Pow(step,2));
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt16(Console.ReadLine());
Square(number);
*/

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
/*
double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}

Console.Write("Input x1: ");
double absc1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double ordi1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double absc2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double ordi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(absc1,ordi1,absc2,ordi2));
*/