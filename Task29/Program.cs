// 
// Функция заполнения массива
int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

// Функция, которая превращает массив в строку.
string GetString(int[] arr)
{
    string getstring = String.Empty;
    int size = arr.Length - 1;
    for (int i = 0; i < size; i++)
    {
        getstring = getstring + arr[i] + ", ";
    }
    getstring = getstring + arr[size];
    return getstring;
}

// Собственно программа, которая использует эти функции и выводит результат в терминал.
int[] array = GenerateArray(8, 0, 100);

string result = GetString(array);
Console.WriteLine($"{result} -> [{result}]");