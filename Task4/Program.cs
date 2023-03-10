// Задача: Напишите програму, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Запрашиваем у пользователя числа и сохраняем их в переменных
Console.WriteLine("Укажите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
// Создаем переменную для хранения самого большого значения, и пока назначаем самым большим первое число
int max = num1;
// Сравниваем все числа с максимумом по очереди, если какое-то окажется больше, назначим самым большим его.
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine(max);