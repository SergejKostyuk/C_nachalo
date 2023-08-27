// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

double DistanceBetweenPoints (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int side1 = x1 - x2;
    int side2 = y1 - y2;
    int side3 = z1 - z2;
    double distance =  Math.Sqrt(side1*side1 + side2 * side2 + side3*side3);
    return distance;
}

Console.WriteLine("Введите координат X1: ");
int xCordinat1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат Y1: ");
int yCordinat1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат Z1: ");
int zCordinat1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат X2: ");
int xCordinat2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат Y2: ");
int yCordinat2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат Z2: ");
int zCordinat2 = Convert.ToInt32(Console.ReadLine());

double result =  DistanceBetweenPoints (xCordinat1, yCordinat1, zCordinat1, xCordinat2, yCordinat2, zCordinat2);
double resultRound = Math.Round(result,2, MidpointRounding.ToZero);
Console.WriteLine(resultRound); 