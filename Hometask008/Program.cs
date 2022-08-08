// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число не равное 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 0;
if (N > 1)
{
    while (count < N - 1)
    {
        result = result + 2;
        Console.Write(result + " ");
        count = count + 2;
    }
}
else
{
    if(N==1 ^ N==0 ^ N==-1)
    {
        Console.Write("В диапазоне от 1 до "+N+" чётных чисел нет");
    }
    else
    {
        while (count > N + 1)
    {
        result = result - 2;
        Console.Write(result + " ");
        count = count - 2;
    }
    }
}