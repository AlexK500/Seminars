// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число:\t");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{n} => {ArrayCom(n)}");


int ArrayCom(int n)
{
    int[] array = new int[n];
    int result = 1;
    for (int i = 0; i < n; i++)
    {
        array[i] = i + 1;
        result = result * array[i];
    }
    return result;
}