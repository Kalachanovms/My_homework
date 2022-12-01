// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

double Tablesquare(double number)
{
    double res = Math.Pow(number, 3);
    return res;
}
Console.WriteLine("Write number N : ");
double number = double.Parse(Console.ReadLine());
double count = 1;
  while ( count <= number)
  {
    double result = Tablesquare(count);
    count++;
    Console.WriteLine(result);
  }