// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void Tablesquare(string str)
{
    Console.WriteLine(str);
    double number = int.Parse(Console.ReadLine());
    double count = 1;
    while ( count <= number)
    {
        double pow = Math.Pow(number, 3);
        Console.Write(pow + " ");
        count ++;
    
    }
        Console.WriteLine();
}

Tablesquare("Write number N : ");