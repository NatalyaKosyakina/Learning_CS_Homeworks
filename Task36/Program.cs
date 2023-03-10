// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Функция создания массива
int[] CreateArrayRndInt(int size, int diapmin, int diapmax)
{
    int[] arrayrnd = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arrayrnd[i] = rnd.Next(diapmin, diapmax + 1);
    }
    return arrayrnd;
}
// Функция вывода массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

// Функция подсчета суммы элементов с нечетным индексом.
int SummOddIndex(int[] array)
{
    int sumOddIndex = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sumOddIndex += array[i];
    }
    return sumOddIndex;
}

// Тело программы.
Console.Write("Укажите длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
if (arraySize < 2) Console.WriteLine("Error: Неправильный ввод");
else
{
    Console.Write("Укажите диапазон: ");
    int min = Convert.ToInt32(Console.ReadLine());
    int max = Convert.ToInt32(Console.ReadLine());

    if (max < min)
    {
        Console.WriteLine();
        Console.WriteLine("Error: Неправильный ввод");
    }
    else
    {
        int[] arrayNew = CreateArrayRndInt(arraySize, min, max);
        PrintArray(arrayNew);

        int sumOI = SummOddIndex(arrayNew);
        Console.WriteLine($" -> {sumOI}");
    }
}