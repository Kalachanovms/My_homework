
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void ReversNumber(int number)
{
    System.Console.WriteLine(number + " ");
    if (number > 1)
        ReversNumber(number - 1);
}
Console.Clear();
int number = DataEntry("Введите натуральное чило : ");
System.Console.WriteLine($"Натуральный числа от {number} до 1 :");
ReversNumber(number);
