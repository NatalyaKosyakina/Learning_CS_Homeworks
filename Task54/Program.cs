// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод упорядочивания строк по убыванию.
void RowDecrease(int[,] matrix)
{
    int size = matrix.GetLength(1);
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < size; i++)
        {
            int min = matrix[k, 0];
            int indexmin = 0;
            for (int j = 0; j < size - i; j++)
            {
                if (matrix[k, j] < min)
                {
                    indexmin = j;
                    min = matrix[k, j];
                }
            }
            matrix[k, indexmin] = matrix[k, size - 1 - i];
            matrix[k, size - 1 - i] = min;
        }
    }
}

// Тело программы
int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

RowDecrease(array2D);
PrintMatrix(array2D);