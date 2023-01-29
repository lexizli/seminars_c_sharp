/*

Задача 54: 

Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Ну ничего себе уже задачка :-) 

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
            Console.Write("{0,5:d2}  ", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


/* сортировка слиянием по убыванию */
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


