// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

int DataInput(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;

}