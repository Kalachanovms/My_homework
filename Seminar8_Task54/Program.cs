// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = 0; count < array.GetLength(1) -1 ; count++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int buffer = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = buffer;
                }
            }
        }
    }
}

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
SortArray(matrix);
System.Console.WriteLine("Сортировка по строкам :");

PrintArray(matrix);





