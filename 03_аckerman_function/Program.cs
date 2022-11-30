﻿// Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return AckermanFunction(m - 1, 1);
    }
    else
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}

Console.Clear();
Console.Write("Введите неотрицательное число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите неотрицательное число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(AckermanFunction(m, n));
