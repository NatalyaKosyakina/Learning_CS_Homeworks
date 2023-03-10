// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Вначале создаем функцию
void CubeN(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5} -> {Math.Pow(count, 3),5} ");
        count++;
    }
}

// затем запрашиваем у пользователя число 
Console.Write("Укажите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
    CubeN(number);
else
    Console.WriteLine("Это не натуральное число");
