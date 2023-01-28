/*
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
*/
/*

int[,] CreateRandom2dArray(int rows,int columns, int minVal, int maxVal)
{
    int[,] array = new int[rows, columns]; 
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minVal,maxVal+1);
        }
    }
    return array;
}


/*
int[,] CreateSumIndex2dArray(int rows,int columns)
{
    int[,] array = new int[rows, columns]; 
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
*/
/*
void Write2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}
/*
void Double2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2) 
    {
        for(int j = 0; j < array.GetLength(1); j += 2) 
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}
*/
/*
int SumArrayDioganal(int[,] array)
    {
        int sum = 0;
        int size;
        if (array.GetLength(0) > array.GetLength(1))
            size = array.GetLength(1);
        else
            size = array.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            sum = sum + array[i, i];
        }
        return sum;
    }

Console.Write("Input number rows in array: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number columns in array: ");
int col = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int minV = Convert.ToInt16(Console.ReadLine());
Console.Write("Input maximum value: ");
int maxV = Convert.ToInt16(Console.ReadLine());

int[,] newArr = CreateRandom2dArray(row, col, minV, maxV);

// int[,] newArr = CreateSumIndex2dArray(row, col);

Write2dArray(newArr);

int sum = SumArrayDioganal(newArr);

Console.WriteLine(sum);


/* Задача 1

Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aij = i+j. 
Выведите полученный массив на экран.
*/

/* Задача 2

Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
*/

/* Задача 3

Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

матрица любых габаритов!
*/


// задачка на проверу из лекции 6

void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

DrawText("Intensive C# Demo text", 29, 10);
