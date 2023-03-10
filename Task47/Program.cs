// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.


// Метод создания двумерного массива вещественных чисел
double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns]; // 0, 1
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
        }
    }
    return matrix;
}

// Метод вывода в консоль двумерного массива вещественных чисел.
void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine($"{matrix[i, matrix.GetLength(1) - 1]}");
    }
}

// Тело программы.
Console.WriteLine("Укажите размер массива:");
Console.Write("m = ");
int rowsM = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int columnsN = Convert.ToInt32(Console.ReadLine());
double[,] matrixDoubleNumbers = CreateMatrixRndDouble(rowsM, columnsN, -10, 100);

PrintMatrix(matrixDoubleNumbers);