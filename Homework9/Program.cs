/*
void ShowToOne(int number)
{
    Console.Write(number + " ");
    if(number < 1) ShowToOne(number + 1);
    if(number > 1) ShowToOne(number - 1);
}


ShowToOne(22);
Console.WriteLine();

ShowToOne(-22);
Console.WriteLine();
*/

/*
int SumFromTo(int num1, int num2)
{
    int sum = 0;
    if(num1 > num2) return sum = sum + num1 + SumFromTo(num1 - 1, num2);
    if(num1 < num2) return sum = sum + num1 + SumFromTo(num1 + 1, num2);
    return sum + num1;
}

Console.WriteLine(SumFromTo(15,1));
Console.WriteLine(SumFromTo(1,15));
Console.WriteLine(SumFromTo(4,8));
Console.WriteLine(SumFromTo(8,4));
*/

int Ackermasha(int num1, int num2)
{
    if(num1 > 0)
    {
        if(num2 > 0) return Ackermasha(num1 - 1, Ackermasha(num1, num2 - 1));
        else return Ackermasha(num1 - 1, 1);
    }
    else return num2 + 1;
}

Console.WriteLine(Ackermasha(2, 3));
Console.WriteLine(Ackermasha(3, 2));
Console.WriteLine(Ackermasha(3, 4));
Console.WriteLine(Ackermasha(3, 5));

