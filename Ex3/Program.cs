Console.WriteLine("Enter m"); 
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n"); 
int n = int.Parse(Console.ReadLine());

int Ack(int m, int n)
{
    if (m == 0)
    {
    return n + 1; // Идем по ветке где m = 0 и n = n + 1 (начиная с 1)
    }
        else 
        if (n == 0)
        {
             return Ack(m - 1, 1); // Ветка с n = 0 
        }
            else
            {
                return Ack(m - 1, Ack(m, n - 1)); // Все остальные случаи с "двойной" рекурсией
            }
 
}

Console.WriteLine($"{Ack(m,n)}"); 