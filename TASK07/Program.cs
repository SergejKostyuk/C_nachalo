// Напишите программу, которая принимает
// на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Вдедите трехзначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

if (chislo <= 0)
{
    chislo*=-1;
}
if (chislo >= 100 && chislo <= 999)
{
    int lastDigit = chislo%10;
    Console.WriteLine("Последняя цифра:  " + lastDigit);  
}
else
{
    Console.WriteLine("Некорректное значение");
}
