/*
1. Задайте двумерный массив. 
2. Напишите программу, которая заменяет строки на столбцы. 
3. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int[,] ReplaceRowsColumns (int[,] matrix)
{
    int[,] tmpArray = new int[matrix.GetLength(0), matrix.GetLength(1)];    

    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            tmpArray[j, i] = matrix[i, j];            
        }        
    }
    return tmpArray;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2}  ");
            else Console.Write($"{matrix[i,j], 2} ");
        }
        Console.WriteLine();
    }
}



int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    int[,] newMatrix = ReplaceRowsColumns (matrix);
    PrintMatrix(newMatrix);
} 
else Console.WriteLine("Число строк и столбцов не совпадает!");
