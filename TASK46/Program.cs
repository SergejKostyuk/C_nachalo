﻿//  Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1   4  8   19
// 5  -2  33  -2
// 77  3  8    1

int[,] CreateMatrixRndInt(int rows , int colunns, int min, int max)
{
    int[,] matrix = new int[rows,colunns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
           matrix[i,j] = rnd.Next(min, max + 1); 
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j], 6}");
        }
        Console.WriteLine("|");
    } 
}


int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, -100, 100);
PrintArray(createMatrixRndInt);
