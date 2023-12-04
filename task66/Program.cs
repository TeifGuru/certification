// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    int sum = 0;
    if (m < n)
    {
        sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
    }
    else if (n < m)
    {
        sum = 0;
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }
    }
    else
    {
        sum = n+m;
    }
    return sum;
}

System.Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

int sum = Sum(m, n);
System.Console.WriteLine($"М={m}; N={n} -> {sum}");