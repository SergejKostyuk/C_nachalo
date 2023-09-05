// Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double XCoordinate (double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    return x;
    
}
double YCoordinate (double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.WriteLine("Введите координату b1: ");
double b1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату k1: ");
double k1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату b2: ");
double b2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату k2: ");
double k2Coordinate = Convert.ToInt32(Console.ReadLine());

double xCoordinate = XCoordinate(b1Coordinate, k1Coordinate, b2Coordinate, k2Coordinate);
double yCoordinate = YCoordinate(b1Coordinate, k1Coordinate, xCoordinate);
Console.WriteLine($"Точка пересечения двух прямых -> ({xCoordinate}; {yCoordinate})");
