// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Clear();
System.Console.WriteLine("Введите количество чисел");

int number = int.Parse(Console.ReadLine()); // задаем количество чисел 
int count = 0;

for (int i = 0; i < number; i++)
{
    Console.Write($"Введите число {i + 1} : "); // номер числа исходя из общего количества
    int x = int.Parse(Console.ReadLine());
    if (x > 0) // сравнивание числа и считаем их 
        count++;
}

System.Console.WriteLine($"Положительных чисел : { count }");