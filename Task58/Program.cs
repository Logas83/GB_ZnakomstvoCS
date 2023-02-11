/*
1. Задайте две матрицы. 
2. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
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
*/

int[,] TestCreateMatrixRndInt(int a11, int a12, int a21, int a22)
{
    int[,] matrix = new int[2, 2];
    matrix[0, 0] = a11;
    matrix[0, 1] = a12;
    matrix[1, 0] = a21;
    matrix[1, 1] = a22;

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}  ");
            else Console.Write($"{matrix[i, j],1} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] newResultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                newResultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return newResultMatrix;
}


/*
int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(matrix2);
*/
int[,] matrix1 = TestCreateMatrixRndInt(2, 4, 3, 2);
Console.WriteLine("Матрица 1");
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = TestCreateMatrixRndInt(3, 4, 3, 3);
Console.WriteLine("Матрица 2");
PrintMatrix(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] resultMatrix = MatrixMultiplication(matrix1, matrix2);
    Console.WriteLine("Результирующая матрица");
    PrintMatrix(resultMatrix);
}
else
{
    Console.WriteLine("Число столбцов матрицы 1 не равняется числу строк матрицы 2.");
    Console.WriteLine("Матрицы перемножать нельзя!");
}