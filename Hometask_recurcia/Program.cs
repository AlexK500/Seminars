Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int Factorial(int n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}
Console.Write(n+ " -> "+Factorial(n));