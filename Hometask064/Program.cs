// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Ввелдите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void OutNum(int n)
{
    if (n > 0)
    {
        Console.Write(n + ", ");
        OutNum(n - 1);
    }
}
OutNum(n);