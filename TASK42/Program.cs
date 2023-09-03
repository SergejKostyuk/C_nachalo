// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int DecimalToBin(int num)
{
    int res = 0;
    int count = 1;
    while (num > 0)
    {
        res = res + num % 2 * count;
        num /= 2;
        count *= 10;
    }
    return res;
}

Console.WriteLine("Введите первую сторону: ");
int number = Convert.ToInt32(Console.ReadLine());

int decimalToBin = DecimalToBin(number);
Console.WriteLine($"Двоичное число - > {decimalToBin}");