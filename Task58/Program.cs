// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Метод создания двумерного массива
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

// Метод вывода в консоль двумерного массива.
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine(matrix[i, matrix.GetLength(1) - 1]);
    }
}

// Метод умножения матриц
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int rowsC = matrixA.GetLength(0); 
    int columnsC = matrixB.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int[,] matrixC = new int[rowsC, columnsC];

    for (int i = 0; i < rowsC; i++)
    {
        for (int j = 0; j < columnsC; j++)
        {
            int sum = 0;
            for (int n = 0; n < rowsB; n++)
            {
                sum += matrixA[i, n] * matrixB[n, j];
            }
            matrixC[i, j] = sum;
        }
    }
    return matrixC;
}
//
int[,] matrix1 = CreateMatrixRndInt(2, 3, 1, 10);
int[,] matrix2 = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(1) == matrix2.GetLongLength(0)) 
{
    int[,] matrixResult = MatrixMultiplication(matrix1, matrix2);
    PrintMatrix(matrixResult);
}
else
{
    Console.WriteLine("Error");
}
