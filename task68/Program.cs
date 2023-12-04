// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Function(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Function(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Function(m - 1, Function(m, n - 1));
    }
    return n;
}

int GetNumber(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}


int m = GetNumber("Введите первое неотрицательное число m");
int n = GetNumber("Введите второе неотрицательное число n");

System.Console.WriteLine($"m={m}, n={n}, A(m,n)={Function(m, n)}");