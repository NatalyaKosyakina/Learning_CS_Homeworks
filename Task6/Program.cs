// Задача: Написать программу, которая на вход принимает число, и выдает, является ли оно чётным
// Запрашиваем у пользователя число
Console.WriteLine("Укажите число");
int number = Convert.ToInt32(Console.ReadLine());
// Проверяем, четное ли оно
if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
Console.WriteLine("нет");