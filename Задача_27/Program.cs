Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()); 

int countNumbers (int m)
{
    int count = 0;
        if (m < 0)
        {
        m = m*(-1); 
        }
        while (m > 0)
        {
        count++;
        m /= 10; 
        }
    return count;
}

int summary (int n)
{
    int sum = 0;
    int x = countNumbers(number);
        if (n < 0)
        {
         n = n*(-1);
        }
        for (int i = 0; i < x; i++) 
        {
        sum = sum+number%10; 
        number = number/10;
        }
    return sum;
}
//Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе {number} равна {summary (number)}");

    