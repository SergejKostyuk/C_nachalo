// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int colunns, int min, int max)
{
    int[,] matrix = new int[rows, colunns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matr[i, j],6}");
        }
        Console.WriteLine("|");
    }
}

double[] ArithmeticMean(int[,] matr)
{

    double[] arr = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
            arr[j] = sum / matr.GetLength(0);
            arr[j] = Math.Round(arr[j], 1, MidpointRounding.ToZero);
        }
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(createMatrixRndInt);
Console.WriteLine();
double[] arithmeticMean = ArithmeticMean(createMatrixRndInt);
PrintArray(arithmeticMean);
