/*
Задача 2.

Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Clear();
Console.WriteLine("Input two number, please, and get the answer — what number is greater or may be them are equal. ");
Console.WriteLine("Use dot (.) please as separetor or you can input integer.");
Console.WriteLine("------------------------------------------------------------");
Console.Write("Input number one, please — ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input one number two, please — ");
double number2 = Convert.ToDouble(Console.ReadLine());
/*
if ( number1 >= number2 ) Console.WriteLine($"First number {number1} is greater or equel to the second number  {number2}");
else Console.WriteLine($"First number {number1} is less than the second number  {number2}");
*/

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

/*
Задача 4.

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
/*
Console.Write("Input integer, please — ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input one more integer, please — ");
int number2 = Convert.ToInt32(Console.ReadLine());
*/