// 

void IsPalindromeNumber(int paliNumber)
{
    int numberSize = 1; int counter = 0; int left = 0; int right = 0; bool palindrome = true;
    int tempNumber = paliNumber;
    while (tempNumber > 10) 
    {
        tempNumber = tempNumber / 10;
        numberSize *= 10;
        counter++;
    }
    
    for (int loop = -1; loop < counter / 2; loop++ )
    {
        left = paliNumber / numberSize;
        right = paliNumber % 10;
        if (left == right)
        {
            paliNumber = paliNumber - left * numberSize;
            paliNumber = paliNumber / 10;
            numberSize = numberSize / 100;
        }
        else palindrome = false;
    } 
if (palindrome) Console.WriteLine("It was digital palindrome!");
else Console.WriteLine("It was usual number and not palindrome!");
  
 }



void IsPalindromeString(string paliString)
{
    Console.WriteLine("String");
}

Console.Clear();
Console.Write("Hello, buddy! Input anyone palindrome here: ");
string inString = Console.ReadLine();

int inNumber = 0;
try
{
    checked
    {
        inNumber = Convert.ToInt32(inString);
        IsPalindromeNumber(inNumber);
    }
}
catch
{
    IsPalindromeString(inString);
}

