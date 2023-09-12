// Напишите программу, которая будет 
// принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigitNum(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigitNum(num / 10);
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigitNum(number));

