// Задайте значение N, M. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());
if (n<m)
    Console.WriteLine("Invalid range");
else
    Console.WriteLine(PrintNumbers(m, n));

// Задать значения M и N Найти сумму натуральных элементов в промежутке от M до N

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

