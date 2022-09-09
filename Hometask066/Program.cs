// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Ввелдите 1-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввелдите 2-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
int SumNum(int m, int n)
{
    if (m > n) return 0;
    return m + SumNum(m + 1, n);
}
Console.Write(SumNum(m, n));