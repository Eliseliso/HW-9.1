// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = GetNum("Введите положительное число: ");
int m = 1;
Console.WriteLine(PrintNum(n, m));
int PrintNum(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{PrintNum(n, m + 1)}, ");
    return m;
}
int GetNum(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}