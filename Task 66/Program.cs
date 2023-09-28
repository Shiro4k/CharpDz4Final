/*
 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
 */

int GetNumber(string message)
{
    Console.Write($"{message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumNumbers(int N, int M)
{
    int Sum = 0;
    if (M == N)
    {
        return 0; 
    }
    else
    {
        M++;
        Sum = M + SumNumbers(N, M);
        return Sum;
    }
}

Console.Clear();
int M = GetNumber("Введите число от M: ");
int N = GetNumber("Введите число до N: ");
int sum = SumNumbers(N, M - 1);
Console.WriteLine(sum);

