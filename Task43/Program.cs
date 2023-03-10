// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Функция для поиска y 
double GetYCoordinate(double numx, int numk, int numb)
{
    return numk * numx + numb;
}

// Функция для поиска x 
double GetXCoordinate(int k1, int b1, int k2, int b2)
{
    return Convert.ToDouble(b2 - b1) / (k1 - k2);
}

// Тело программы.
Console.Write("Введите числа: b1 = ");
int numberb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
int numberk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int numberb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int numberk2 = Convert.ToInt32(Console.ReadLine());
if (numberk1 == numberk2)
{
    Console.WriteLine("Точки пересечения не существует");
}
else
{
    double xCoordinate = GetXCoordinate(numberk1, numberb1, numberk2, numberb2);
    double yCoordinate = GetYCoordinate(xCoordinate, numberk1, numberb1);

    Console.WriteLine($"b1 = {numberb1}, k1 = {numberk1}, b2 = {numberb2}, k2 = {numberk2} -> ({xCoordinate}; {yCoordinate})");
}