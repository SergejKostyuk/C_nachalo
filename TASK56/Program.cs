// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System.Diagnostics.CodeAnalysis;

int[,] CreateDoblMatrix(int rows, int colunns, int minNumber, int maxNumber)
{
    int[,] matrix = new int[rows, colunns];
    Random arr = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = arr.Next(minNumber, maxNumber + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1)) Console.Write($"{matr[i, j],4} |");
        }
        Console.WriteLine(" ");
    }
}

int[] SumRow(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
            arr[i] = sum;
        }
    }
    return arr;
}

void RouComparison(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {index + 1}");
}

int[,] createDoblMatrix = CreateDoblMatrix(5, 5, 0, 10);
PrintMatrix(createDoblMatrix);
Console.WriteLine();
int[] sumRow = SumRow(createDoblMatrix);
RouComparison(sumRow);
