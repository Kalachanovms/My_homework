// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateRandomArray(int rows, int columns, int leftrange, int rirghtrange) // метод создания массива
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftrange, rirghtrange + 1);
        }
    }
    return array;
}


void PrintArray(int[,] array)// метод вывода массива 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            System.Console.Write($"[{array[i, j]}]");

        }
        System.Console.WriteLine();
    }

}

int EnterNumber(string message) // метод чтения строки
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int m = EnterNumber("Введите значение m : "); // значение массива
int n = EnterNumber("Введите значение n : "); // значение массива


int[,] matrix = CreateRandomArray(m, n, 0, 10); // 0-10 диапазон , m/n высота/ширина

PrintArray(matrix); // печать массива
