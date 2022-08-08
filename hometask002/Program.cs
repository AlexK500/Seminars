// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine("Первое число "+numberA+" больше второго числа "+numberB);
}
else
{
    if(numberA == numberB)
    {
        Console.WriteLine("Числ равны между собой");
    }
    else
    {
        Console.WriteLine("Второе число "+numberB+" больше первого числа "+numberA);
    }
    
    
}
