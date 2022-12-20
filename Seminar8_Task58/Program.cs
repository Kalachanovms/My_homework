// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void CompositionOfTwoMatrix(int[,] first, int[,] second, int[,] product)
{
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
                sum += first[i, k] * second[k, j];
            }
            product[i, j] = sum;

        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("[" + array[i, j] + "]");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}

int AddNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int columsFirst = AddNumber("Введите количесвто столбцов для матрицы 1");
int linesFirst = AddNumber("Введите количесвто строк для матрицы 1");
int clomusSecond = AddNumber("Введите количесвто столбцов для матрицы 2");
int linesSecond = AddNumber("Введите количесвто строк для матрицы 2");
if (columsFirst == linesSecond)
{
    int[,] firstMatrix = new int[columsFirst, linesFirst];
    int[,] secondMatrix = new int[clomusSecond, linesSecond];
    FillMatrixRandomNumbers(firstMatrix);
    FillMatrixRandomNumbers(secondMatrix);
    PrintMatrix(firstMatrix);
    System.Console.WriteLine();
    PrintMatrix(secondMatrix);
    int[,] multipMatrix = new int[columsFirst, linesSecond];
    CompositionOfTwoMatrix(firstMatrix, secondMatrix, multipMatrix);
    System.Console.WriteLine();
    System.Console.WriteLine("Результат : ");
    System.Console.WriteLine();
    PrintMatrix(multipMatrix);
}
else
    System.Console.WriteLine("Перемножить нельзя");