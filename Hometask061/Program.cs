// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

int factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++) x *= i;
    return x;
}

Console.Write("Введите количество строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int a = 0; a <= (n - i); a++) Console.Write(" ");
    for (int a = 0; a <= i; a++)
    {
        Console.Write(" ");
        Console.Write(factorial(i) / (factorial(a) * factorial(i - a))); //вычесляем элементы треугольника
    }
    Console.WriteLine();
}
Console.WriteLine();


