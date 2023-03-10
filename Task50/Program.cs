// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine($"{matrix[i, matrix.GetLength(1) - 1]}]");
    }
}

// Метод проверки области поиска
bool CheckInsideMatrix(int rows, int columns, int[,] matrix)
{
    return (rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1));
}

// Тело программмы
int[,] array2D = CreateMatrixRndInt(3, 4, 10, 100);
PrintMatrix(array2D);
Console.WriteLine();

Console.WriteLine("Укажите позицию элемента: ");
Console.WriteLine("строка:  ");
int rowsM = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("столбец:  ");
int columnsN = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine(CheckInsideMatrix(rowsM, columnsN, array2D)
? array2D[rowsM, columnsN]
: " -> Такого числа в массиве нет");