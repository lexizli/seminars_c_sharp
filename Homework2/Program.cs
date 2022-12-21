//  Homework 2

/*  Задача 10: 
    Напишите программу, которая принимает на вход трёхзначное число 
    и на выходе показывает вторую цифру этого числа.
*/

/*
int MiddleDigit(int inputNumber)
{
    return (inputNumber / 10) % 10;
}

bool key = false;
Console.Clear();
int inNumber = 0;

while (inNumber < 100 || inNumber > 999)
{
    try
    {
        if ( key ) Console.WriteLine("\nIt was not correct number.");
        Console.Write("\nInput, please, three digits positive number: ");
        inNumber = Convert.ToInt32(Console.ReadLine());
        key = true;
    }
    catch
    {
        Console.WriteLine("\nIt was not correct number.");
        key = false;
    }
}

Console.WriteLine("\nOK, thank you!\n\nThe middle digit of inputed number is " + MiddleDigit(inNumber));
*/

/*  Задача 13: 
    Напишите программу, которая выводит третью цифру заданного числа 
    или сообщает, что третьей цифры нет.

    Тут не стал проверять на ввод не чисел
*/

/*
string ThirdDigit(double inputNumber)
{
    long temp = 0;
    try
    {
        checked
        {
            temp = Math.Abs((long)inputNumber);
        }
    }
    catch (OverflowException e)
    {
        return "\nIt's tooooooooooooooooooo long number, sorry";
    }

    if (temp < 100) return "\nIn integer part of inputed number third digit is absent";
    while (temp > 999 ) temp = temp / 10;
    temp = temp % 10;
    return "\nThird digit is " + temp;

}
Console.Clear();
Console.WriteLine("\nInput number and i'll show you third number of it's integer part.\nWhen you want to exit input, please, -1");

double inNumber = 0.0;
while (inNumber != -1)
{
    Console.Write("\nInput your number please: ");
    inNumber = Convert.ToDouble(Console.ReadLine());
    if (inNumber == -1) Console.WriteLine("Bye!");
    else
    {
        Console.WriteLine(ThirdDigit(inNumber));
    }
}
*/

/*  Задача 15: 
    Напишите программу, которая принимает на вход цифру, 
    обозначающую день недели, и проверяет, является ли этот день выходным.

*/

bool IsWeekend(int day)
{
    return day == 6 || day == 7 ? true : false;
}

Console.Clear();
Console.Write("\nInput number of day from 1 till 7: ");
int inNumber = Convert.ToInt16(Console.ReadLine());
if (inNumber < 1 || inNumber > 7) Console.WriteLine("It was wrong input, bye!");
else
{
    if (IsWeekend(inNumber))
    {
        Console.WriteLine("—> yes!");
    }
    else
    {
        Console.WriteLine("—> no :-(");
    }
}

