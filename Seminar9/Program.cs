
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(25);
*/
/*

int SumOfDigits(int num)
{
    if(num > 0) return SumOfDigits(num/10) + num % 10;
    else return 0;

}

Console.WriteLine(SumOfDigits(64738291));
*/
/*
Задача 1
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Задача 2
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
*/

/*
void ShowSerialNums(int num1, int num2)
{
    // num1 = 10 num2 = 5
   if (num1 > num2)
    {
        Console.Write(num1 + " ");
        ShowSerialNums(num1 - 1, num2);
    }
        
    else if (num1 < num2)
    {
        ShowSerialNums(num2 - 1, num1);
        Console.Write(num2 + " ");
    }
    else Console.Write(num2 + " ");

}

ShowSerialNums(2, 10);
*/

double Stepen(double num1, int num2)
{
    if(num2 > 0) return num1 * Stepen(num1, num2 - 1);
    if(num2 < 0) return 1/num1 * Stepen(num1, num2 + 1);
    else return 1;
}

Console.WriteLine(Stepen(2, -4));