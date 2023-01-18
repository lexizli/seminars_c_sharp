/* Задача 25: 

Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

int PowerAB(int number, int exponent)
{
    int power = number;
    for(int i = 1; i < exponent; i++) power = power * number;
    return power;
}


Console.Write("Input number A (base): ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B (exponent): ");
int exponent = Convert.ToInt32(Console.ReadLine());

Console.Write($"number {number} ^ exponent {exponent} = ");
Console.WriteLine(PowerAB(number, exponent));
*/

/* Задача 27: 

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumOfDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits in number {number} = {SumOfDigits(number)}");

*/

/* Задача 29: 

Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal,maxVal+1);
    }
    return array;
}

void WriteArray( int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
}

Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int minV = Convert.ToInt16(Console.ReadLine());
Console.Write("Input maximum value: ");
int maxV = Convert.ToInt16(Console.ReadLine());

int[] newArr = CreateRandomArray(number,minV,maxV);
WriteArray(newArr);

*/

/* Задача 29: вариант 2.

Можно и так, но меньше контроля за массивом 

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void WriteArray( int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
    Console.WriteLine();
}


Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());

int[] newArr = CreateRandomArray(number);
WriteArray(newArr);

*/