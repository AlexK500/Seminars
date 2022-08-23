// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    if (i <= 1)
    {
        array[i] = i;
    }
    else
    {
        array[i] = array[i - 1] + array[i - 2];
    }
}
Console.Write("Если N = " + n + " -> " + String.Join(" ", array));