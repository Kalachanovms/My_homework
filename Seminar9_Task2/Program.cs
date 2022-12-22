// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = ReadingLIne("Введите число M : ");
int n = ReadingLIne("Введите число N : ");

int ReadingLIne(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void SumNaturalElements(int m, int n, int sum)
{
    if (m > n)
    {
        System.Console.WriteLine($"Сумма натуральны чисел равна : {sum} ");
        return;
    }

    sum += m++;
    SumNaturalElements(m, n, sum);
}

SumNaturalElements( m,  n, 0);


