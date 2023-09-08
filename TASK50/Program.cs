// Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет


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

void PrintArray(int[,] matr)
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

bool IndexInTheMatrix(int[,] matr, int lin, int colum)
{
    return matr.GetLength(0) >= lin && matr.GetLength(1) >= colum;
}

void PrintNumberIndex(int[,] matrix, int lin, int colum)
{
    Console.WriteLine($"Число находящееся на позиции {lin},{colum} -> {matrix[lin, colum]}");
}

Console.WriteLine("Введите первый индекс(строки): ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый индекс(столбца): ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, -100, 100);
PrintArray(createMatrixRndInt);
Console.WriteLine();
bool indexInTheMatrix = IndexInTheMatrix(createMatrixRndInt, line, column);
if (indexInTheMatrix) PrintNumberIndex(createMatrixRndInt, line, column);
else Console.WriteLine("Такого элемента в массиве нет");
