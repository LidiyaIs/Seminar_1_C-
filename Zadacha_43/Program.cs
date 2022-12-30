// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine ("Введите данные для первой прямой");
Console.Write ("угловой коэффициент: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write ("свободный коэффициент: ");
int b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите данные для второй прямой");
Console.Write ("угловой коэффициент: ");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write ("свободный коэффициент: ");
int b2 = int.Parse(Console.ReadLine()!);
SearchPoint (k1,b1,k2,b2);

void SearchPoint(int m1,int n1,int m2,int n2)
{
    if (m1!= m2)
    Console.WriteLine($"Точка пересечения двух прямых в координатах ({(n2 - n1)/(m1 - m2)};{m1 * ((n2 - n1) / (m1 - m2)) + n1})");
    else Console.WriteLine("Прямые параллельны");
}