// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Функция
int GetSumm(int num)
{
    int sum = 0;
    while (num >= 1)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

// Программа, которая запрашивает у пользователя число, проверяет его и выводит результат.
Console.Write("Укажите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

int getsum = GetSumm(number);
Console.WriteLine($"{number} -> {getsum}");