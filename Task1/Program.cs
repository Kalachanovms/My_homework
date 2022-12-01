// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число: ");

string number = Console.ReadLine();

Char[] revnumber = number.ToCharArray();
Array.Reverse(revnumber);

string ? finalnumer = new string(revnumber);

int numberA = Convert.ToInt32(number);
int numberB = Convert.ToInt32(finalnumer);

    if(numberA == numberB)
    {
    Console.WriteLine(" Yes ");
    }
    if(numberA != numberB)
    {
        Console.WriteLine("No");
    }


// Console.WriteLine(revnumber);

