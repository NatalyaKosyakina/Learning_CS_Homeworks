// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Создаем функцию

bool Weekend(int digit)
{
    return (digit == 6 || digit == 7);
}

// Запрашиваем у пользователя число, проверяем, подходит ли нам оно.
Console.Write("Укажите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Error");
}

// Передаем число в функцию и выводим ответ
else 
{
bool weekend = Weekend(number);
Console.WriteLine(weekend ? "да": "нет");
}