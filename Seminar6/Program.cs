// Seminar 6


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

void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

int[] CopyIntArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++) newArray[i] = array[i];

    return newArray;
}


Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int minV = Convert.ToInt16(Console.ReadLine());
Console.Write("Input maximum value: ");
int maxV = Convert.ToInt16(Console.ReadLine());

int[] newArr = CreateRandomArray(number,minV,maxV);
WriteArray(newArr);
//  ReverseArray(newArr);
// WriteArray(newArr);
int[] newArray = CopyIntArray(newArr);
newArr[0] = 100;
WriteArray(newArr);
WriteArray(newArray);


// задача 1
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// задача 2
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: a и b. 
/*
double Fibonacci(double number)
{
    double a = 1;
    double b = 1;

    for (int i = 3; i <= number; i++ )
    {
        double c = a + b;
        a = b;
        b = c;
     }
     return b;
}

Console.WriteLine(Fibonacci(10));

*/
// задача 3
// Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.