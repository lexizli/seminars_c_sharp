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
Задача 58: 

Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
*/


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
