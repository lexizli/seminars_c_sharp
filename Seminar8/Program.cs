/*
Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
/*
void ChangeRows(int[,] array, int r1, int r2)
{
    if (r1 >= 0 && r1 < array.GetLength(0) &&
       r2 >= 0 && r2 < array.GetLength(0) &&
       r1 != r2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
    
}
*/

/* задача 1

Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы.
Для квадратного массива


void TransArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = 1 + i; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }


    }
}
*/



/* Задача 2

Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.

*/

int[] PlaceOfMin(int[,] array)
{
    int[] minimumPlace = {0, 0};

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] < array[minimumPlace[0],minimumPlace[1]]) 
                {
                    minimumPlace[0] = i;
                    minimumPlace[1] = j;
                }
            }
        }
        return minimumPlace;
}

int[,] RemoveFromArray(int[,] array, int[] Position)
{
    int[,] newArray =  new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i - Convert.ToInt32((i >= Position[0] + 1)),j - Convert.ToInt32((j >= Position[1] + 1))] = array[i, j];
        }
    }
    return newArray;
}

Console.Write("Input number rows in array: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number columns in array: ");
int col = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int minV = Convert.ToInt16(Console.ReadLine());
Console.Write("Input maximum value: ");
int maxV = Convert.ToInt16(Console.ReadLine());
Console.Write("Input row1: ");
int row1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Input row2: ");
int row2 = Convert.ToInt16(Console.ReadLine());


int[,] newArr = CreateRandom2dArray(row, col, minV, maxV);
Write2dArray(newArr);

int[] Position = PlaceOfMin(newArr);
//ChangeRows(newArr, row1, row2);
//TransArray(newArr);

int[,] superNewArray = RemoveFromArray(newArr, Position);
Write2dArray(superNewArray); 