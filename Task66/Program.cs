// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRecBetwen(int num1, int num2)
{
    if (num1 == num2) return num2;
    if (num1 > num2)
    {
        int tmp = num2;
        num2 = num1;
        num1 = tmp;
    }
    if ((num2 - num1) % 2 == 0) return num1 + num2 + SumRecBetwen(num1 + 1, num2 - 1);
    return num1 + SumRecBetwen(num1 + 1, num2);  // 4+ 

}

Console.WriteLine("Укажите два натуральных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int numberRes = SumRecBetwen(number1, number2);
Console.WriteLine($"M = {number1}; N = {number2} -> {numberRes}");