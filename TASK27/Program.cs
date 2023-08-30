// Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе. 

int SumNumbers (int numb)
{
    int sum=0;
    while (numb > 0)
    {
        sum = sum + (numb %10);
        numb = numb /10;
    } return sum;
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Сумма цифр числа {number} ----> {result}");
