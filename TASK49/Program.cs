// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
void SearchEvenIndexRaplaceQuart(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            //if (i % 2 == 0 && j % 2 == 0) matrix[i,j] *=matrix[i,j];
            matrix[i,j] *=matrix[i,j];
        }
    }
}


int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, 0, 10);
PrintArray(createMatrixRndInt);
Console.WriteLine();
SearchEvenIndexRaplaceQuart(createMatrixRndInt);
PrintArray(createMatrixRndInt);
