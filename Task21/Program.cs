// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Создаем функцию
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.WriteLine("Укажите координаты первой точки");
int numx1 = Convert.ToInt32(Console.ReadLine());
int numy1 = Convert.ToInt32(Console.ReadLine());
int numz1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите координаты второй точки");

int numx2 = Convert.ToInt32(Console.ReadLine());
int numy2 = Convert.ToInt32(Console.ReadLine());
int numz2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(numx1, numy1, numz1, numx2, numy2, numz2);
distance = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"A({numx1}, {numy1}, {numz1}); B({numx2}, {numy2}, {numz2} -> {distance}");