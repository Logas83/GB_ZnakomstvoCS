/*
1. Задайте двумерный массив. 
2. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}  ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();        
    }
}

int[,] SortMatrix(int[,] matrix)
{
    int tmp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int sort = j + 1; sort < matrix.GetLength(1); sort++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < matrix[i, sort])
                {
                    tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, sort];
                    matrix[i, sort] = tmp;
                }
            }
        }
    }
    return matrix;
}


int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] sortMatrix = SortMatrix(matrix);
PrintMatrix(sortMatrix);