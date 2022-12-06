// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

int Read(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = Read("Введите число A: ");
int NumberB = Read("Введите число B: ");

Degree(numberA, NumberB);

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    Console.WriteLine("A в натуральной степени B = " + result);
}

// Complete