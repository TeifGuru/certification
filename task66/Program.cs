// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
   if(m==n)
   {
    return n;
   }
   return m+Sum(m+1,n);
}

int GetNumber(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}


int min = GetNumber("Введите минимальное число");
int max = GetNumber("Введите максимальное число");

System.Console.WriteLine($"Мin={min}; Max={max} -> {Sum(min, max)}");