/*  Задача 19

    Напишите программу, которая принимает на вход пятизначное число 
    и проверяет, является ли оно палиндромом.

    Сделал для всех положительных целых чисел, т. к. знак минуса ломает палиндром,
    а также для фраз-палиндромов
*/
/*

void IsPalindromeNumber(int paliNumber)
{
    int numberSize = 1; int counter = 0; int left = 0; int right = 0; bool palindrome = true;
    int tempNumber = paliNumber;
    while (tempNumber > 10)
    {
        tempNumber = tempNumber / 10;
        numberSize *= 10;
        counter++;
    }

    for (int loop = -1; loop < counter / 2; loop++)
    {
        left = paliNumber / numberSize;
        right = paliNumber % 10;
        if (left == right)
        {
            paliNumber = paliNumber - left * numberSize;
            paliNumber = paliNumber / 10;
            numberSize = numberSize / 100;
        }
        else palindrome = false;
    }
    if (palindrome) Console.WriteLine("It was digital palindrome!");
    else Console.WriteLine("It was usual number and not the palindrome!");

}

void IsPalindromeString(string paliString)
{
    paliString = paliString.ToLower();
    paliString = System.Text.RegularExpressions.Regex.Replace(paliString, "\\W", "");
    int left = 0; int right = paliString.Length - 1; bool palindrome = true;

    while (left < right)
    {
        if (paliString[left] != paliString[right]) palindrome = false;
        left++;
        right--;
    }
    if (palindrome) Console.WriteLine("It it correct palindrome!");
    else Console.WriteLine("It was usual set of charachters and not the palindrome!");



    //    Console.WriteLine("String ->" + paliString);

}

Console.Clear();
Console.Write("Hello, buddy! Input anyone palindrome here: ");
string inString = Console.ReadLine();

int inNumber = 0;
try
{
    checked
    {
        inNumber = Convert.ToInt32(inString);
        IsPalindromeNumber(inNumber);
    }
}
catch
{
    IsPalindromeString(inString);
}
*/

/*  Задача 21
    Напишите программу, которая принимает на вход координаты двух точек 
    и находит расстояние между ними в 3D пространстве.
*/
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
}


Console.Clear();
Console.WriteLine("I can calculate distance between two points in 3D space\nenter, please, coordinates for points.\n\nFirst point: ");
Console.Write("x1 -> ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 -> ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1 -> ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n\nSecond point: ");
Console.Write("x2 -> ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 -> ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2 -> ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n\nThe distance is equel: " + Math.Round(Distance( x1,  y1,  z1,  x2,  y2,  z2),2));
*/

/*  Задача 23
    Напишите программу, которая принимает на вход число (N) 
    и выдаёт таблицу кубов чисел от 1 до N.
    Мощная задача!
    Не вижу только, зачем тут использовать метод :-) 
*/

Console.Clear();
Console.WriteLine("Input integer number please and get the subsequence of cube numbers inputed number an 1");
Console.WriteLine("------------------------------------------------------------");
Console.Write("Input number, please: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++) Console.WriteLine((Math.Pow(i, 3)));
