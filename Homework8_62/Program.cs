/*
Задача 62. 

Напишите программу, которая заполнит спирально массив

*/

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

int[,] spirallyArray(int row, int column)
{
    int maxNumber = row * column;
    int[,] array = new int[row, column];

    int i = 0;
    int j = 0;
    int colBegin = 0;
    int colEnd = array.GetLength(1);
    int rowBegin = 0;
    int rowEnd = array.GetLength(0);
    int k = 1;

    while (k <= maxNumber)
    {
        for (j = colBegin; j < colEnd; j++)
        {
            array[i, j] = k++;
        }
        j--;
        for (i = rowBegin + 1; i < rowEnd; i++)
        {
            array[i, j] = k++;
        }
        i--;
        for (j = colEnd - 2; j > colBegin; j--)
        {
            array[i, j] = k++;
        }

        for (i = rowEnd - 1; i > rowBegin; i--)
        {
            array[i, j] = k++;
        }
        i++;
        colBegin++;
        rowBegin++;
        colEnd--;
        rowEnd--;

    }

    return array;
}


int[,] newArray = spirallyArray(8, 6);
Write2dArray(newArray);