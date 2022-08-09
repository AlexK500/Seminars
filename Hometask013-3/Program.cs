// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение третьим способом добавил Math.Abs и переработадл while (length > 999) без подсчета количества цифр.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int length = Math.Abs(number);
    while (length > 999)
    {
        length /= 10;
    }
    Console.WriteLine(length % 10);
}