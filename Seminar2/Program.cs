// Seminar 2
/*
int CutNumber(int number)
{
    return 10 * (number / 100) + number%10;
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine(CutNumber(number));
*/
/*
int BiggestNumber(int numb)
{

    int dec = numb / 10; // 37 / 10 = 3
    int edi = numb % 10; // 37 % 10 = 7 

    if ( dec == edi ) { return -1; }

    if ( dec > edi )
    {
        return dec;
    }
    else
    {
        return edi;
    }
}



int number = new Random().Next(10, 100);
Console.WriteLine(number);
Console.WriteLine(BiggestNumber(number));
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

bool IsDevided(int number1, int number2)
{
    if ( number2 % number1 == 0 ) return true;
    else return false;
}


Console.Clear();
Console.WriteLine("Input two number please and get the answer — is second number devided at first. ");
Console.WriteLine("------------------------------------------------------------");
Console.Write("Input number one, please: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input one number two, please: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if ( IsDevided(number1, number2)) Console.WriteLine ($"{number1} devided at {number2}");
else Console.WriteLine ($"{number1} not devided at {number2}");

