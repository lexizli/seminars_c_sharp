/*
Задача 60. 

Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Интересная задачка, но кажется мне, что можно удаление чисел, которые уже попали в массив, сделать получше.

Есть предложения?

*/

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int[,,] Create3dArrayRandomSerials(int row, int column, int layer, int[] serials)
{
    int[,,] array = new int[row, column, layer];
    for (int k = 0; k < layer; k++)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                int index = new Random().Next(0, serials.Length);
                array[i, j, k] = serials[index];
                int[] newSerials = DecreaseTwoDigitsArray(serials, index);
                Array.Resize(ref serials, serials.Length - 1);
                for (int m = 0; m < serials.Length; m++)
                {
                    serials[m] = newSerials[m];
                }

            }
        }
    }
    return array;
}

void Write3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,5:d2} ", array[i, j, k]);
                Console.Write($"({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[] DecreaseTwoDigitsArray(int[] array, int position)
{
    if (array.Length > 2)
    {
        int[] copyStepDown = new int[array.Length - 1];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == position) continue;
            copyStepDown[j] = array[i];
            j++;
        }
        return copyStepDown;
    }
    else
    {
        int[] copyStepDown = new int[1];
        copyStepDown[0] = 100;
        return copyStepDown;
    }
}

int[] CreateSerialArray(int first, int last)
{
    int[] array = new int[Math.Abs(last - first + 1)];
    for (int i = 0; i < array.Length; i++)
    {
        if (first < last) array[i] = first++;
        else array[i] = first--;
    }
    return array;
}

int[] workArray = CreateSerialArray(10, 99);
WriteArray(workArray);

int[,,] new3dArray = Create3dArrayRandomSerials(3, 4, 5, workArray);
Write3dArray(new3dArray);