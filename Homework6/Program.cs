/*
Задача 41: 

Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

Не понял, где тут место для метода. 
*/
/*
Console.Clear();
Console.Write("Hi, buddy! Input any number here or any word for exit: ");
int counterAll = 0;
int counterPositive = 0;
while (true)
{
    if (counterAll > 0) Console.Write("one more: ");
    string inString = Console.ReadLine();
    int inNumber = 0;
    try
    {
        checked
        {
            inNumber = Convert.ToInt32(inString);
            counterAll++;
            if(inNumber > 0) counterPositive++;
        }
    }
    catch
    {
        break;
    }
}
Console.WriteLine($"It was {counterAll} numbers (M = {counterAll}) and {counterPositive} positive number inputed");
*/

/* 
Задача 43: 

Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.Clear();
Console.WriteLine("Now I will try to find the crossing point of two straight lines,");
Console.WriteLine("described as y = Kx + B ");
Console.WriteLine("\nand you have to input ");
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2) 
{
    if(b1 == b2) Console.WriteLine("We have a infinite numbers of crossing points\nso this is the same line!");
    else Console.WriteLine("We haven't crossing point.\nThis is parralels.");
}
else{
    double abscissa = (b2 - b1) / (k1 - k2);
    double  ordinate = abscissa * k1 + b1;
    Console.WriteLine($"We have crossing point in x = {abscissa} and y = {ordinate}.");
}