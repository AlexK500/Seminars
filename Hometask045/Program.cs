// /Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] RndArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = RndArray(5, 0, 10);
int[] arrayCopy = new int[array.Length];
for (int i = 0; i < array.Length; i++) arrayCopy[i] = array[i];
Console.Write('['+string.Join(", ", array)+"] -> ");
Console.Write('['+string.Join(", ", arrayCopy)+']');