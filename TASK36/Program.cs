// Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random arr = new();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arr.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("Масссив: [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumEvenElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0 || i % 2 == 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] createArray = CreateArray(sizeArray, -10, 100);
PrintArray(createArray);

int sumEvenElements = SumEvenElements(createArray);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях -> {sumEvenElements}");
