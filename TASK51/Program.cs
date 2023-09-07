// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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

int SearchSumElementsMainDiagonale(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j) sum += matrix[i,j];
        }
    }
    return sum;
}

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, 0, 10);
PrintArray(createMatrixRndInt);
Console.WriteLine();
int searchSumElementsMainDiagonale = SearchSumElementsMainDiagonale(createMatrixRndInt);
Console.WriteLine(searchSumElementsMainDiagonale);