// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Sub(int start, int end)
{
        if(start<end)
    {
        return;
    }
    Sub(start,end+1);
    System.Console.Write($"{end} ");
}

System.Console.WriteLine("Введите число");
int start = Convert.ToInt32(Console.ReadLine());
int end=1;
Sub(start,end);