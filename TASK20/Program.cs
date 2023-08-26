// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = 5.098725;
// double dRound = Math.Round(d,2, MidpointRounding.ToZero);
// Console.WriteLine(dRound); // форматирование до 2-ух знаков после запятой 

// Console.WriteLine($"{d:F}"); // форматирование до 2-ух знаков после запятой

double DistanceBetweenPoints (int x1, int y1, int x2, int y2)
{
    int side1 = x1 - x2;
    int side2 = y1 - y2;
    double distance =  Math.Sqrt(side1*side1 + side2 * side2);
    return distance;
}

Console.WriteLine("Введите координаты первой точки x1: ");
int xCordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки y1: ");
int yCordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки x2: ");
int xCordinate2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки y2: ");
int yCordinate2 = Convert.ToInt32(Console.ReadLine());

double result =  DistanceBetweenPoints (xCordinate1, yCordinate1, xCordinate2, yCordinate2);
double resultRound = Math.Round(result,2, MidpointRounding.ToZero);
Console.WriteLine(resultRound); 


