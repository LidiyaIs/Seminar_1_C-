// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int a, int b)
{
    if (a==0) return b+1;
        else if (b==0) return Akkerman(a-1,1);
            else return Akkerman(a-1,Akkerman(a,b-1));    
}
Console.WriteLine("Введите 2 неотрицательных числа");
Console.Write("1:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("2:");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Результат функции Аккермана: {Akkerman(m,n)}");