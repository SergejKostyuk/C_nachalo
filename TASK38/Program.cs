﻿// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max) //создание массива с дробными числами
{
    double[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min; // чтобы получить нужный диапазон нужно произвести умножение
    } 
    return arr;
}

void PrintArrayDouble(double[] arr) // вывод массива с отсечением до 1 знака после запятой
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]:F1}"); // F1 - означает округление числа но 2 знаков после запятой
    }
    Console.WriteLine("]");
}