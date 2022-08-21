int[] RandomArray(int leng)
{
    int[] arr = new int[leng];
    for (int i = 0; i < leng; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}


Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length > 0)
{
int[] array = RandomArray(length);

Console.WriteLine($"[{String.Join(", ", array)}]");
int count=0;
for (int j = 0; j < length; j++)
{
    if (array[j]%2==0)
    {
        count++;
    }
}
Console.WriteLine($"Четных чисел в массиве: {count}");
}
else
{
    Console.WriteLine("Некорректная длина массива!");
}