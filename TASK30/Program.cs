// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray (int [] array, int min, int max)
{
    Random rende = new Random();// менее затратное решение

    for (int i = 0; i <array.Length; i++)
    {
        array[i] = rende.Next(min, max +1); // менее затратное решение
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
Console.WriteLine("Введите минимальную цифру для заполнения массива: ");
int minNumberArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальную цифру для заполнения массива: ");
int maxNumberArray = Convert.ToInt32(Console.ReadLine());

int [] arra = new int [sizeArray];

Console.Write("Массив случайных чисел: ");
FillArray(arra, minNumberArray, maxNumberArray);
PrintArray(arra);