// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// Метод поиска минимальной суммы элементов по строкам.
int RowMinimalSumm(int[,] matrix)
{
    int min = 0;
    int indexMin = 0;
    int rowSize = matrix.GetLength(1);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < rowSize; j++)
        {
            sum += matrix[i, j];
        }
        if (sum < min)
        {
            min = sum;
            indexMin = i;
        }
    }
    return indexMin + 1;
}


// Вызов методов.
int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

Console.WriteLine($"{RowMinimalSumm(array2d)} строка");