// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumMN(int a, int b)
{
    if (a==b) return a;
    else return a + SumMN(a+1,b);    
}
Console.WriteLine("Введите 2 натуральных числа");
Console.Write("1:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("2:");
int n = int.Parse(Console.ReadLine()!);
int summa;
if (m>n) summa=SumMN (n,m);
else summa=SumMN (m,n);
Console.WriteLine($"Сумма от {m} до {n} равна: {summa}");