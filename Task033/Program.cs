// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int[] array = new int[5];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(number == array[i])
    {
        count++;
    }
}
if(count == 0)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}