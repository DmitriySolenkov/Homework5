int[] RandomArray(int leng)
{
    int[] arr = new int[leng];
    for (int i = 0; i < leng; i++)
    {
        arr[i] = new Random().Next(0, 99);
    }
    return arr;
}


Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if(length>1)
{
int[] array = RandomArray(length);

Console.WriteLine($"[{String.Join(", ", array)}]");

int sum=0;
for (int j = 0; j < length; j++)
{
    if (j%2!=0)
    {
        sum += array[j];
    }
}

Console.WriteLine($"Сумма элементов массива, стояших на нечетных позициях: {sum}");
}
else
{
    Console.WriteLine("Некорректная длина массива!");
}