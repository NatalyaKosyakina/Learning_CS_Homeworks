// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

// Функция подсчета количества четных жлементов массива

int NumberEvenElements(int[] array)
{
    int numberEvenElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            numberEvenElements++;
        }
    }
    return numberEvenElements;
}

// Тело программы.
Console.Write("Укажите длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize < 2) Console.WriteLine("Error: Неправильный ввод");
else
{
    int[] arrayThreeDigit = CreateArrayRndInt(arraySize, 100, 999);
    PrintArray(arrayThreeDigit);

    int result = NumberEvenElements(arrayThreeDigit);
    Console.WriteLine($" -> {result}");
}