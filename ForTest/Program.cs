
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "  ");
    Console.WriteLine();
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
    int[] array = new int[Math.Abs(last - first)];
    for (int i = 0; i < array.Length; i++)
    {
        if (first < last) array[i] = first++;
        else array[i] = first--;
    }
    return array;
}

int[] workArray = CreateSerialArray(11, 22);
WriteArray(workArray);
int[] workArray2 = DecreaseTwoDigitsArray(workArray, 5);
WriteArray(workArray2);
