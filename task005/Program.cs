Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
//-----------Для неотрицательного числа--------------------
/*while(count <= N)
{
    Console.WriteLine(count);
    count++;
}
*/
//-----------Для любого целого числа-----------------------
if(count < N)
{
    while(count <= N)
    {
        Console.WriteLine(count);
        count++;
    }
}
else
{
    while(count >= N)
    {
        Console.WriteLine(N);
        N++;
    }
}

