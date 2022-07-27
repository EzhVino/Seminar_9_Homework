// ЗАДАЙТЕ ЗНАЧЕНИЕ N, M. НАПИШИТЕ ПРОГРАММУ, КОТОРАЯ ВЫВЕДЕТ ВСЕ НАТУРАЛЬНЫЕ ЧИСЛА В ПРОМЕЖУТКЕ ОТ M ДО N

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// Console.Write("Enter M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine());
// if (n < m)
//     Console.WriteLine("Invalid range");
// else
//     Console.WriteLine(PrintNumbers(m, n));

// ЗАДАЙТЕ ЗНАЧЕНИЯ M И N. НАПИШИТЕ ПРОГРАММУ, КОТОРАЯ НАЙДЁТ СУММУ НАТУРАЛЬНЫХ ЭЛЕМЕНТОВ В ПРОМЕЖУТКЕ ОТ M ДО N

// int SumNumbers(int numFirst, int numSecond)
// {
//     if (numFirst == numSecond) return numSecond;
//     return (numFirst + SumNumbers(numFirst + 1, numSecond));
// }

// Console.Write("Enter M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < m)
//     Console.WriteLine("Invalid range");
// else
//     Console.WriteLine(SumNumbers(m, n));

// НАПИШИТЕ ПРОГРАММУ ВЫЧИСЛЕНИЯ ФУНКЦИИ АККЕРМАНА С ПОМОЩЬЮ РЕКУРСИИ. ДАНЫ ДВА НЕОТРИЦАТЕЛЬНЫХ ЧИСЛА M И N

int Ackermann(int frstNum, int sndNum)
{
    if (frstNum == 0)
        return sndNum + 1;
    else if (frstNum > 0 && sndNum == 0)
        return Ackermann(frstNum - 1, 1);
    else if (frstNum > 0 && sndNum > 0)
        return Ackermann(frstNum - 1, Ackermann(frstNum, sndNum - 1));
    throw new Exception ("Incorrect arguments"); 
}

Console.Clear();
Console.Write("Enter positive number M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter positive number N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Result of the Ackermann function is {Ackermann(m, n)}");