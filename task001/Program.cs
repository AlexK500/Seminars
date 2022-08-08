Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB * numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
