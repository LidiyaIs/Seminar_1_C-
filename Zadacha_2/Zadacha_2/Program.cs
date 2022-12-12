Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Число {a} большее, число {b} меньшее");
}
if (a < b)
{
    Console.WriteLine($"Число {b} большее, число {a} меньшее");
}
if (a == b)
{
    Console.WriteLine($"Числа {a} и {b} равны");
}