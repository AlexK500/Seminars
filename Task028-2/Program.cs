int ArrayCom(int n)
{
    int[] array = new int[n];
    int result = 1;
    for (int i = 0; i < n; i++)
    {
        array[i] = i + 1;
        result = result * array[i];
    }
    return result;
}
Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elementsCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индехом {i}:\t");
    myArray[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"{myArray[i]} => {ArrayCom(myArray[i])}");
}