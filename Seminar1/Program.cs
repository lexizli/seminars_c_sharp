/* 
Console.Write("Input some integer, please — ");

int number1 = Convert.ToInt32(Console.ReadLine());

double b = 7 / 13;

Console.WriteLine("Inputed number is " + number + " Hello, World! " + b);
*/
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input some integer, please — ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input one more integer, please — ");
int number2 = Convert.ToInt32(Console.ReadLine());

if ( number1 / number2 == number2 ) Console.WriteLine($"Inputed number {number1} is square of {number2}");
else Console.WriteLine($"Sorry, inputed number {number1} is not square of {number2}");
