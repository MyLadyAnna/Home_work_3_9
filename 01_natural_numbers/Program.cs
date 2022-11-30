// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void OutputOfNaturalNumbers(int N, int M = 1)
{
    if (N >= M)
    {
        Console.Write($"{N} ");
        OutputOfNaturalNumbers(N - 1);
        return;
    }
    return;
}

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

OutputOfNaturalNumbers(n);
