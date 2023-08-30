// Напишите цикл, который принимает на вход два
// числа (А, В) и возводит в натуральную степень В.

using System.ComponentModel.DataAnnotations.Schema;

bool NaturalNumber (int degre)
{
    if (degre >= 0) 
    {
        return true;
    } else return false;

}

double CockingGegree (int numb, int degr)
{
    double result = Convert.ToInt32(Math.Pow(numb, degr));
    return result;
}

Console.WriteLine("Введите число которое нужно взвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для взведения в степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (NaturalNumber(degree) == true)
{
    double res = CockingGegree(number, degree);
    Console.WriteLine($"Число {number} в степени {degree} --> {res}");
} else 
{
    Console.WriteLine("Введите натуральное число степени!");
}


