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
            Console.Write("{0,5:d2}  ", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/* 
Задача 56: 

Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int RowNumberWithLeastSum(int[,] array)
{
    int leastSumOfRow = 0;
    int currentSumOfRow = 0;
    int indexOfLeast = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSumOfRow += array[i, j];
        }
        if(i == 0) 
        {
            leastSumOfRow = currentSumOfRow;
        } 
        else if(currentSumOfRow < leastSumOfRow)
        {
            leastSumOfRow = currentSumOfRow;
            indexOfLeast = i;
        }
        currentSumOfRow = 0;
    }
    return indexOfLeast+1;
}


int[,] newArr = CreateRandom2dArray(6, 3, 1, 11);
Write2dArray(newArr);
Console.WriteLine("Minimal sum of elements is in the row " + RowNumberWithLeastSum(newArr));