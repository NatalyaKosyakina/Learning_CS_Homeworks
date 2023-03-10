// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

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

// Функция подсчета положительных чисел
int GetNumberOfPositive(int[] array)
{
    int sumpos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumpos++;
    }
    return sumpos;
}

// Тело программы
Console.WriteLine("Укажите общее количество чисел: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
// Проверка
if (sizeArr > 2)
{
    int[] array1 = new int[sizeArr];
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < sizeArr; i++)
    {
        array1[i] = Convert.ToInt32(Console.ReadLine());
    }
    PrintArray(array1);
    int numberOfPositive = GetNumberOfPositive(array1);
    Console.WriteLine($" -> {numberOfPositive}");
}
else
{
    Console.WriteLine("Error");
}