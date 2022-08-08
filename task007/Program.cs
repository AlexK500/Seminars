Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N > 99 & N < 1000)
{
    Console.WriteLine(N%10);
}
else
{
    Console.WriteLine("Число не подходит");
}
