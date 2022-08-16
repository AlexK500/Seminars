// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elementsCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индехом {i}:\t");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[");
for (int i = 0; i < myArray.Length - 1; i++)
    Console.Write($" {myArray[i]}, ");
Console.Write($" {myArray[myArray.Length - 1]}]");