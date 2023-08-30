// Напишите программу, которая задаёт
// массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.

void FillArray (int [] array)
{
    Random rende = new Random();// менее затратное решение

    for (int i = 0; i <array.Length; i++)
    {
        array[i] = rende.Next(0, 100); // менее затратное решение
        //array[i] = new Random().Next(2); // создание рандомного заполнения более ресурсо затратный
    }
}

void PrintArray (int [] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write(ar[i] + " "); 
    }
}

Console.WriteLine("Введите размер массива от 1 до N: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int [] arra = new int [sizeArray];

Console.Write($"Массив из {sizeArray} случайных чисел от 0 до 99: ");
FillArray(arra);
PrintArray(arra);