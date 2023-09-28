/*
 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 */

int GetNumber(string message)
{
    Console.Write($"{message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int FunctionAkkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return FunctionAkkerman(M - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(M - 1, FunctionAkkerman(M, N - 1)));
    }
}



Console.Clear();
int M = GetNumber("Введите число M: ");
int N = GetNumber("Введите число N: ");
int akk = FunctionAkkerman(M, N);
Console.WriteLine(akk);