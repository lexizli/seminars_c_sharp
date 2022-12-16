/*
Задача 2.

Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
/*
Console.Clear();
Console.WriteLine("Input two number please and get the answer — what number is greater or may be them are equal. ");
Console.WriteLine("Use dot (.) as separetor or you can input integer.");
Console.WriteLine("------------------------------------------------------------");
Console.Write("Input number one, please: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input one number two, please: ");
double number2 = Convert.ToDouble(Console.ReadLine());
/*
if ( number1 >= number2 ) Console.WriteLine($"First number {number1} is greater or equel to the second number  {number2}");
else Console.WriteLine($"First number {number1} is less than the second number  {number2}");
*/
/*
switch (number2 - number1)
{
    case > 0:
    Console.WriteLine($"First number {number1} is less than the second number  {number2}");
    break;

    case 0:
    Console.WriteLine($"First number {number1} is equal the second number  {number2}");
    break;

    case < 0:
    Console.WriteLine($"First number {number1} is greater than the second number  {number2}");
    break;
}
*/



/*
Задача 4.

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
/*
Console.Clear();
Console.WriteLine("Input three number please and get the answer — what number is the greatest. ");
Console.WriteLine("Use dot (.) as separetor or you can input integer.");
Console.WriteLine("------------------------------------------------------------");
Console.Write("Input number one, please: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input one number two, please: ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the last number, please: ");
double number3 = Convert.ToDouble(Console.ReadLine());

if ((number1 == number2) & (number2 == number3)) Console.WriteLine($"All numbers are equal");
else
{

    if (number1 > number2)
    {
        if (number1 > number3) Console.WriteLine($"First number {number1} is the biggest (maximal)");
    }
    else
    {
        if (number2 > number3) Console.WriteLine($"Second number {number2} is the biggest (maximal)");
        else Console.WriteLine($"Third number {number3} is the biggest (maximal)");
    }
}
*/

/*
Задача 6.

Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
/*
Console.Clear();
Console.WriteLine("Input integer number please and get the answer — is it number even. ");
Console.WriteLine("------------------------------------------------------------");
Console.Write("Input number, please: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number % 2 == 0) Console.WriteLine($"Number {number} is even");
*/

/*
Задача 8.

Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

Console.Clear();
Console.WriteLine("Input integer number please and get the subsequence of even numbers between inputed number an 1. ");
Console.WriteLine("------------------------------------------------------------");
Console.Write("Input number, please: ");
int number = Convert.ToInt32(Console.ReadLine());
int start  = 0, finish = 0;

if ( (number / 2) < 1)
{
    start = number / 2;
    finish = 0;
}
else
{
    start = 1;
    finish = number / 2;
}

for (int i = start; i <= finish; i++) Console.WriteLine((i * 2));
