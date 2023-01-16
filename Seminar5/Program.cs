// Seminar 5

int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "  ");
    Console.WriteLine();
}


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// Написать программу, которая определяет сумму отрицательных элементов в массиве.
/*
int GetSumOfNegative(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++) if (array[i] < 0 ) sum += array[i];
    return sum;
}
*/
/*
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(length);


WriteArray(newArray);
Console.WriteLine(GetSumOfNegative(newArray));
*/

// Написать программу, заменяющую положительные элементы массива на отрицательные и наоборот.

int[] MirrorArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}


// Написать программу, определяющую, присутствует ли заданное число в массиве.

bool IsNumberInArray(int[] array, int numb)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == numb) return true;  //когда пробежали по всем и ничего не нашли
    return false;
}


// Задать массив из n элементов, определить кол-во элементов, принадлежащих отрезку [a,b].

int NumbersInArray(int[] array, int a, int b)
{
    if(a > b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= a && array[i] <= b) counter++;   
    }
    return counter;
}

int[] testArray;
testArray = CreateRandomArray(21, -11, 11);
WriteArray(testArray);
WriteArray(MirrorArray(testArray));

Console.WriteLine(IsNumberInArray(testArray, 0));
Console.WriteLine(NumbersInArray(testArray, -5, 5));