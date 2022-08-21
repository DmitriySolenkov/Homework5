double[] RandomArray(int leng)
{
    double[] arr = new double[leng];
    for (int i = 0; i < leng; i++)
    {
        arr[i] = new Random().NextDouble()*100;
        arr[i]= Math.Round(arr[i],2);
    }
    return arr;
}


Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length>1)
{
double[] array = RandomArray(length);
Console.WriteLine($"[{String.Join("; ", array)}]");

double min=array[0];
double max=array[0];

for (int j = 0; j < length; j++)
{
    if (array[j]<min)
    {
        min=array[j];
    }
    if (array[j]>max)
    {
        max=array[j];
    }
}
Console.WriteLine($"Разница между минимальным и максимальным элементом массива: {Math.Round(max-min,2)}");
}
else
{
    Console.WriteLine("Некорректная длина массива!");
}