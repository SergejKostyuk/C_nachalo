// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] OrderedMatrixFromMore(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1 - j; k++)
            {
                if (matr[i,k] < matr[i,k + 1])
                {
                    temp = matr[i,k + 1];
                    matr[i,k + 1] = matr[i,k];
                    matr[i,k] = temp;
                }
            }
        }
    }
    return matr;

}

int[,] createDoblMatrix = CreateDoblMatrix(3, 4, 0, 99);
PrintMatrix(createDoblMatrix);
Console.WriteLine();
int[,] orderedMatrixFromMore = OrderedMatrixFromMore(createDoblMatrix);
PrintMatrix(orderedMatrixFromMore);
