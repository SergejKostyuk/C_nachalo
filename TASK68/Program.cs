// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System.Globalization;

Console.WriteLine("Введите неотрицательное число m: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool CheckNumber(int num1, int num2)
{
    return (num1 < 4 && num1 > 0) && (num2 < 11 && num2 > 0);
}

int Akkerman(int num1, int num2)
{
    while (num1 != 0)
    {
        if (num2 == 0)
        {
            num2 = 1;
        }
        else
        {
            num2 = Akkerman(num1, num2 - 1);
        }
        num1 -= 1;
    }
    return num2 + 1;
}

if (CheckNumber(number1, number2))
{
    int akkerman = Akkerman(number1, number2);
    Console.WriteLine($"A({number1},{number2}) -> {akkerman}");
}
Console.WriteLine("Число m не должно превышать значение 3, а число n не должно превышать значение 11");


