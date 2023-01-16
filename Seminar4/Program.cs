// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N..
/*
int Factor(int number)
{
    int result = 1;
    for (int step = 1; step <= number; step++ ) result *= step;
    return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(Factor(number));
*/

int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal,maxVal+1);
    }
    return array;
}

void WriteArray( int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
}

Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int minV = Convert.ToInt16(Console.ReadLine());
Console.Write("Input maximum value: ");
int maxV = Convert.ToInt16(Console.ReadLine());

int[] newArr = CreateRandomArray(number,minV,maxV);
WriteArray(newArr);