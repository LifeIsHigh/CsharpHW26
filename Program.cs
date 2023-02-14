// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter Value M --> ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Value N --> ");
int N = Convert.ToInt32(Console.ReadLine());

int Summ = 0;

int SummNaturalElements(int M)
{
    if (M > N)
        return 0;
    else if (M > 0)
        return Summ = M + SummNaturalElements(M + 1);
    else
        return SummNaturalElements(M + 1);
}

void Elements()
{
    if (M == N)
    { Console.WriteLine(M); }
    else if (M < 0 && N < 0)
    { Console.WriteLine("Negative values are entered"); }
    else if (M < N && N > 0)
    { SummNaturalElements(M); }
}
Elements();
Console.Write($"{SummNaturalElements(M)} ");