// Напишите программу, которая принимает
// на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число, от 100 до 999 -> ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ResultSecondNumber(number);
Console.WriteLine(result);


int ResultSecondNumber(int numb)
{
    return result = numb /10 % 10;

}