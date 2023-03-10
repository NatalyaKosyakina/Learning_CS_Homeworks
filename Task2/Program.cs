// Задача: Написать программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.
// Запрашиваем у пользователя числа
Console.WriteLine("Укажите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
// Сравниваем числа и выводим результат
if (num1 >= num2)
{
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine($"max = {num2}");
}