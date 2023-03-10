// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//
int AckrmanFunction(int numM, int numN)
{
    if (numM == 0) return numN +1;
    else if (numM > 0 && numN == 0)
    {
        return AckrmanFunction(numM - 1, 1);
    }
    else if (numM > 0 && numN > 0)
    {
        return AckrmanFunction(numM - 1, AckrmanFunction(numM, numN - 1));
    }
    else return numM + 1;
}

//
Console.WriteLine("Введите два неотрицательных числа");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

int result = AckrmanFunction(numberM, numberN);
Console.WriteLine($"m = {numberN}, n = {numberM} -> A(m,n) = {result}");