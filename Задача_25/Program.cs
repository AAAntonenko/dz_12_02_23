Console.Clear();
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int resultAB (int res)
{
    int product = a;
    {
    for (int i = 2; i <= res; i++)
        product = product*a;
    }
    return product;
}


Console.WriteLine($"{resultAB (b)}");