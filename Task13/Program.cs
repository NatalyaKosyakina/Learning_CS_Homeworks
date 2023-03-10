// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Создаем функцию
int GetThirdDigit(int number)
{
    if (number < -100) // Если число отрицательное, сделаем его положительным.
    {
        number = -1* number;
    }
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    return number;
}

// Запрашиваем у пользователя число

Console.Write("Укажите число:  ");
int number1 = Convert.ToInt32(Console.ReadLine());


// Проверяем, есть ли третья цифра
if (number1 < 100 & number1 > -100)   
{
    Console.WriteLine("третьей цифры нет");
}
else
{
int thirdDigit =  GetThirdDigit(number1); // подставляем число в функцию и выводим возвращенный результат.
Console.WriteLine(thirdDigit);
}