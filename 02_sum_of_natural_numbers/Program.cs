// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumOfNumbers(int M, int N)
{
    if (M == N)
    {
        return M;

    }
    return M + GetSumOfNumbers(M + 1, N);

}

Console.Clear();
Console.Write("Введите меньшее число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите большее число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(GetSumOfNumbers(m, n));
