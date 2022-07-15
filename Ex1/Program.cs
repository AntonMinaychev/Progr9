Console.WriteLine("Enter m (must be < n)"); 
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n"); 
int n = int.Parse(Console.ReadLine());


int mult(int n)
{
    if (n == m) return n; // Условие выхода - "дохождение" n до m
    else
    return n * mult(n-1);
}

Console.WriteLine($"{mult(n)}"); 