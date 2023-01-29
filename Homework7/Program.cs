/*
Задача 47

Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

*/
/*
double[,] CreateRandom2dArray(int rows, int columns, double minVal, double maxVal)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
    {
        array[i,j] = new Random().Next((int)minVal, (int)maxVal+1) + rnd.NextDouble();
    }
    }
    return array;
}

void Write2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write("{0,10:#.00000}  ", array[i, j]);
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}
*/
/*
Console.Write("Input number rows in array: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number columns in array: ");
int col = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
double minV = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maximum value: ");
double maxV = Convert.ToDouble(Console.ReadLine());

double[,] newArr = CreateRandom2dArray(row, col, minV, maxV);

Write2dArray(newArr);

*/

/*
Задача 50

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
и возвращает значение этого элемента или сообщает, что такого элемента нет.

*/
/*
string GetValueInArrayByIndexes(double[,] array, int row, int column)
{
    if(row - 1 > array.GetLength(0) || column -1 > array.GetLength(1)) return "Element's position is owt of borders of given array, sorry!";
    return array[row-1, column-1].ToString("F5");
}

Console.Write("Input number rows in array: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number columns in array: ");
int col = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
double minV = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maximum value: ");
double maxV = Convert.ToDouble(Console.ReadLine());

double[,] newArr = CreateRandom2dArray(row, col, minV, maxV);
Write2dArray(newArr);

Console.Write("Input position in array, row number: ");
int rowNumber = Convert.ToInt16(Console.ReadLine());
Console.Write("Input position in array, column number: ");
int colNumber = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(GetValueInArrayByIndexes(newArr, rowNumber, colNumber));
*/

/*
Задача 52

Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/

int[,] CreateRandom2dArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void WriteAverageInColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++) average += array[j, i];
        Console.Write("{0,10:#.00000}  ", average/array.GetLength(0));
    }
    Console.WriteLine();
}

Console.Write("Input number rows in array: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number columns in array: ");
int col = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int minV = Convert.ToUInt32(Console.ReadLine());
Console.Write("Input maximum value: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int[,] newArr = CreateRandom2dArray(row, col, minV, maxV);
Write2dArray(newArr);

WriteAverageInColumns(newArr);
