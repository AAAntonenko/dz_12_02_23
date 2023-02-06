Console.Clear();
int num = 8;

int[] buildArray(int size)
{
    Console.Write("Минимальный предел массива: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Максивальный предел массива: ");
    int b = int.Parse(Console.ReadLine());
    {   
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
        result[i] = new Random().Next(a, b+1);
        }
    return result;
    }
}

int[] array = buildArray(num);
Console.Write($"[{String.Join(", ", array)}]");