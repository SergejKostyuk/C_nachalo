// Задайте массив заполненный случайными
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] CreateArray (int size)
{
    int [] array = new int [size];
    Random arr = new Random();
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = arr.Next(100,1000);
    }
    return array;
}

void PrintArray (int [] arr)
{
    Console.Write("Массив из трехзначных чисел: [ ");
    for (int i = 0; i <arr.Length; i++)
    {
        if (i < arr.Length -1 ) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine(" ]");
}

int CountEvenNumber (int [] arrCount)
{
    int count = 0;
    for (int i = 0; i <arrCount.Length; i++)
    {
        if (arrCount[i] %2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] createArray = CreateArray(size);
PrintArray(createArray);
int countEvenNumber = CountEvenNumber(createArray);
Console.WriteLine($"Количество четных чисел в массиве -> {countEvenNumber}");
