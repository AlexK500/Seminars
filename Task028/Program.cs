// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// int i = 1;
// while(i<=n)
// {
//     result=result*i;
//     i++;
// }
// Console.Write(result);

int[] array = new int [n];
int result = 1;
for(int i=0; i<n; i++)
{
    array[i] = i+1;
    result =result*array[i];
}
foreach(int e in array)
Console.Write($"{e}, ");
Console.Write("");
Console.WriteLine($" => {result}");