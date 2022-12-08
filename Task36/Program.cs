// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0 )
    {
        result = result + array[i];
    }
}

System.Console.WriteLine("Сумма нечетных чисел в массиве равна : " + result);