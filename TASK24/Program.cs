﻿// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers (int num)
{
   int sum = 0;
   for (int i = 1; i <= num; i++)
   {
    checked // проверяет на переполнение числа
    {
        sum += i; // sum = sum + i; 
    }
   } 
   return sum;
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($" Сумма чисел от 1 до {number} = {result}");