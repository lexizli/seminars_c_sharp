/* Задача 34: 

Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArrayThreeDigit(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,999);
    }
    return array;
}

int EvenCounter(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++) if(array[i] % 2 == 0) counter++;
    return counter;
}

void WriteArray( int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
    Console.WriteLine();
}

Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());


int[] newArr = CreateRandomArrayThreeDigit(number);
WriteArray(newArr);
Console.WriteLine($"Even numbers quantity in array = {EvenCounter(newArr)}");

*/

/* Задача 36: 

Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal,maxVal+1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
    Console.WriteLine();
}

int SumOfOdd(int[] array)
{
    int oddSum = 0;
    for(int i = 1; i < array.Length; i = i + 2) oddSum += array[i];
    return oddSum;
}

Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int minV = Convert.ToInt16(Console.ReadLine());
Console.Write("Input maximum value: ");
int maxV = Convert.ToInt16(Console.ReadLine());

int[] newArr = CreateRandomArray(number,minV,maxV);
WriteArray(newArr);

Console.WriteLine($"Sum of odd numbers in array = {SumOfOdd(newArr)}");

*/

/* Задача 38: 

Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/

double[] CreateRandomArray(int size, double minVal, double maxVal)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next((int)minVal, (int)maxVal+1) + rnd.NextDouble();
    }
    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
    Console.WriteLine();
}

double Distance(double[] array)
{
    double maxi = array[0];
    double mini = array[0];
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i] > maxi) 
        {
            maxi = array[i];
        }
        else if(array[i] < mini) mini = array[i];
    }
    return maxi - mini;
}

Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
double minV = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maximum value: ");
double maxV = Convert.ToDouble(Console.ReadLine());

double[] newArr = CreateRandomArray(number,minV,maxV);
WriteArray(newArr);
Console.WriteLine($"Maximal distance in this array = {Distance(newArr)}");
