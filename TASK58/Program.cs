// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool MultiplicationCheckMatrix (int[,] matrixOne, int[,] matrixTo)
{
    return matrixOne.GetLength(0) == matrixTo.GetLength(0);
}

int[,] ProductMatrices(int[,] matrixOne, int[,] matrixTo)
{
    int[,] multiplicationMatrix = new int[matrixOne.GetLength(0), matrixTo.GetLength(1)];
    for (int rowsOne = 0; rowsOne < matrixOne.GetLength(0); rowsOne++)
    {
        for (int colunnsTo = 0; colunnsTo < matrixTo.GetLength(1); colunnsTo++)
        {
            for (int rowsTo = 0; rowsTo < matrixTo.GetLength(0); rowsTo++)
            {
                multiplicationMatrix[rowsOne, colunnsTo] += matrixOne[rowsOne, rowsTo] * matrixTo[rowsTo, colunnsTo];
            }
        }
    }
    return multiplicationMatrix;
}

int[,] matrix1 = CreateDoblMatrix(2, 2, 1, 10);
int[,] matrix2 = CreateDoblMatrix(2, 2, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
bool multiplicationCheckMatrix = MultiplicationCheckMatrix (matrix1, matrix2);
if (multiplicationCheckMatrix)
{
    int[,] productMatrices = ProductMatrices(matrix1, matrix2);
    PrintMatrix(productMatrices);
} else Console.WriteLine("Умножение невозможно");

