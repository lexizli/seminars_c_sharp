/*

Задача 54: 

Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Ну ничего себе уже задачка :-) 

*/

/*
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


/* сортировка слиянием по убыванию
void SortByCounting(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    int[] tempArray = new int[max + 1];

    for (int j = 0; j < array.Length; j++)
    {
        ++tempArray[array[j]];
    }

    int k = 0;
    for (int i = max; i >= 0; i--)
    {
        for (int j = 0; j < tempArray[i]; j++)
        {
            array[k++] = i;
        }
    }
}

void SliceAndSort(int[,] array)
{
    int[] slice = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            slice[j] = array[i, j];
        }
        SortByCounting(slice);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = slice[j];
        }
    }
}

int[,] newArr = CreateRandom2dArray(8, 8, 1, 123);
Write2dArray(newArr);
SliceAndSort(newArr);
Write2dArray(newArr);

*/

/* 
Задача 56: 

Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

*/

/*
Задача 58: 

Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
*/


/*
int[,] ProductOfMatrix(int[,] array1, int[,] array2)
{
    if (array2.GetLength(1) == array1.GetLength(0))
    {
        int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
        for(int i=0; i < array1.GetLength(0); i++)
        {
            for(int j=0; j < array2.GetLength(1); j++)
            {
                for(int m=0; m < array1.GetLength(1); m++)
                {
                    array[i, j] += array1[i, m] * array2[m, j];
                }
            }
        }
        return array;
    }
    else
    {
        int[,] array = new int[1, 1];
        array[0, 0] = 0;
        return array;
    }
}

int[,] newArrayFirst = CreateRandom2dArray(2, 3, 1, 9);
Write2dArray(newArrayFirst);
int[,] newArraySecond = CreateRandom2dArray(3, 2, 1, 5);
Write2dArray(newArraySecond);
int[,] multipliedArray = ProductOfMatrix(newArrayFirst, newArraySecond);
Write2dArray(multipliedArray);

*/
