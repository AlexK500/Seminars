// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] A = new int[2, 2];
A[0, 0] = 2;
A[0, 1] = 4;
A[1, 0] = 3;
A[1, 1] = 2;

int[,] B = new int[2, 2];
B[0, 0] = 3;
B[0, 1] = 4;
B[1, 0] = 3;
B[1, 1] = 3;

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("\nМатрица A:");
Print(A);
Console.WriteLine("\nМатрица B:");
Print(B);
Console.WriteLine("\nМатрица C = A * B:");
int[,] C = Multiplication(A, B);
Print(C);


int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

