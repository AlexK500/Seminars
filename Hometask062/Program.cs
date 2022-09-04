// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine();
Console.Write("Введите размер матрицы N x N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Spiral(int n)
{
    int count = 1;
    int[,] spirArr = new int[n, n];
    
    for (int k = 0; k <= n / 2; k++)
    {
        if (k == 0)
        {
            for (int i = 0; i < n; i++)
            {
                spirArr[0, i] = count;
                count++;
            }

        }
        else
        {
            count = count - 1;
            for (int i = k - 1; i < n - k; i++)
            {
                spirArr[k, i] = count;
                count++;
            }
        }

        count = count - 1;
        for (int i = k; i < n - k; i++)
        {
            spirArr[i, n - k - 1] = count;
            count++;
        }

        count = count - 1;
        for (int i = n - k - 1; i >= k; i--)
        {
            spirArr[n - k - 1, i] = count;
            count++;
        }

        count = count - 1;
        for (int i = n - k - 1; i >= k + 1; i--)
        {
            spirArr[i, k] = count;
            count++;

        }
    }

    return spirArr;
}

Console.WriteLine();
Console.WriteLine("Матрица - спираль {0} x {1}:", n,n);
Console.WriteLine();
int[,] matrix = Spiral(n);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {

        if (matrix[i, j] < 10)
        {
            Console.Write(" 0" + matrix[i, j] + " ");
        }
        else
        {
            Console.Write(" " + matrix[i, j] + " ");
        }



    }
    Console.WriteLine();
}
Console.WriteLine();