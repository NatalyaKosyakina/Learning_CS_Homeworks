// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Функция создания массива вещественных чисел (double)
double[] CreateArrayRndReal(int size, int diapmin, int diapmax)
{
    double[] arrayrnd = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arrayrnd[i] = Math.Round((rnd.NextDouble() * (diapmax - diapmin) + diapmin), 1);
    }
    return arrayrnd;
}
// Функция вывода массива
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

// Функция вычисления разности между максимальным и минимальным элементом
double DifferenceOfMinMax(double[] array)
{
    double minnumber = array[0];
    double maxnumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minnumber) minnumber = array[i];
        if (array[i] > maxnumber) maxnumber = array[i];
    }
    double diffOfMinMax = maxnumber - minnumber;
    return Math.Round(diffOfMinMax, 1);
}
// Тело программы.
Console.Write("Укажите длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
if (arraySize > 2)
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
        double[] RealNumbers = CreateArrayRndReal(arraySize, min, max);
        PrintArray(RealNumbers);
        double differenceOfMinMax = DifferenceOfMinMax(RealNumbers);
        Console.WriteLine($" -> {differenceOfMinMax}");
    }
}
else Console.WriteLine("Error: Неправильный ввод");