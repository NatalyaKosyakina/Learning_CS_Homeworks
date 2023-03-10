// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Создаем функцию

bool Palindrome(int number)
{
    int mirror = number;
    int res = 0;
    while (number > 0)
    {
    res = (res * 10) + (number % 10);
    number = number/10;
    }
    return (res == mirror);
}
// Запрашиваем число и выводим результат.

Console.Write("Укажите пятизначное число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Palindrome(num1) ? "да" : "нет");