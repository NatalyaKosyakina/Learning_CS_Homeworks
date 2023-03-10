// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// Метод поиска среднего арифметического по столбцам.
double AverageOfColumn(int[,] matrix, int column)
{
    double sum = matrix[0, column];
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, column];
    }
    double result = (double)(sum / matrix.GetLength(0));
    return Math.Round(result, 2);
}

// Тело программы.

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int size = array2D.GetLength(1) - 1;
Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{AverageOfColumn(array2D, i)}, ");
    }
Console.WriteLine($"{AverageOfColumn(array2D, size)}.");