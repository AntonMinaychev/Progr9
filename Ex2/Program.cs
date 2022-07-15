Console.WriteLine("Enter m"); 
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n"); 
int n = int.Parse(Console.ReadLine());
int temp;

if (m > n) // Меняем значения для корректной работы рекурсии
{
temp = m;
m = n;
n = temp;
}

int sum(int n)
{
    if (n == m) return n; // Условие выхода - "дохождение" n до m
    else
    return n + sum(n-1);
}

Console.WriteLine($"{sum(n)}"); 