// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


bool IsExistTriangle(int side1, int side2, int side3)
{
    return (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side2 + side1);
}

Console.WriteLine("Введите первую сторону: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону: ");
int numberThree = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(numberOne, numberTwo, numberThree);
Console.WriteLine(result? "Треугольник существует":"Треугольник не существует");