// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();


const int size = 4;
const int leftRange = 100;
const int rightRange = 999;

int[] array = new int[size];

int[] FillArrayNew(int size, int leftRange, int rightRange) //Метод для создания массива с любым количеством знаков
{
    Random rand = new Random(); // Переменная класса Random

    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

array = FillArrayNew(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join(",", array) + ']'); // Позволяет вывести весь массив через определенные знаки препинания

int MaxNumber = array.Max();
int MinNumber = array.Min();
int result = MaxNumber - MinNumber;

System.Console.WriteLine("Разница между максимальным и минимальным числом =  " + result);