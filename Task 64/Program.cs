/*
 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void GetShislo(int N, int Count = 1)
{
    if (Count == N)
    {
        Console.WriteLine(N);
        return;
    }
    Console.Write($"{N--}, ");
    GetShislo(N, Count);
}

Console.Clear();
int N = SetNumber("Введите число N");
GetShislo(N);