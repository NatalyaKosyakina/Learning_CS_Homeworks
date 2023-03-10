// Задача: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Возведение в степень
int Exponentation(int num1, int num2)
{
    int exponum = 1;
    for (int i = 0; i < num2; i++)
    {
        exponum = exponum * num1;
    }
    return exponum;
}

// Собственно, программа, которая запрашивает у пользователя числа и выводит результат.

Console.WriteLine("Укажите два натуральных числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 > 0)
{
    int exponumber = Exponentation(number1, number2);
    Console.WriteLine($"{number1}, {number2} -> {exponumber}");
}
else
    Console.WriteLine("Error");