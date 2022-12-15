// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write ("Введите натуральное число:");
int N = int.Parse (Console.ReadLine()!);

Console.WriteLine($"Таблица кубов от 1 до {N}: ");
for (int i=1; i<(N+1); i++)
{
        Console.Write (Math.Pow (i,3) +" ");
}