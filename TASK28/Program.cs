// Напишите программу, которая
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int MultiplyNumber (int num)
{
   int mult = 1;
   for (int i = 1; i <= num; i++)
   {
    checked // проверяет на переполнение числа
    {
        mult *= i; // mult = mult * i; 
    }
   } 
   return mult;
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = MultiplyNumber(number);
Console.WriteLine($" Сумма чисел от 1 до {number} = {result}");