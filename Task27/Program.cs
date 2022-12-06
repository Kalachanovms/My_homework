// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

int WriteNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int SumNumber( int number)
{

    int sum = 0;

    for (sum = 0; number != 0; number = number / 10)
    {
        int count = number % 10;
        sum = sum + count;
    }
    return sum;
}

int result = WriteNumber("Write Number");
int sum = SumNumber(result);

Console.WriteLine("Sum numbers = " + sum);