// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int DataEntry(string str)
{
    Console.WriteLine(str);
    int line = int.Parse(Console.ReadLine());
    return line;
}

double CalcDistance(int x, int y, int s, int x1, int y1, int s1)
{

    double result = Math.Sqrt(Math.Pow(x1- x,2) + Math.Pow(y1 - y,2) + Math.Pow(s1 - s, 2));
    return result;
}

int x = DataEntry("Введите координаты X : = ");
int y = DataEntry("Введите координаты Y = ");
int s = DataEntry("Введите координаты S = ");

int x1 = DataEntry("Введите координаты X1 = ");
int y1 = DataEntry("Введите координаты Y1 = ");
int s1 = DataEntry("Введите координаты S1 = ");



double distance = CalcDistance(x, y, s, x1, y1, s1);
Console.WriteLine(distance);