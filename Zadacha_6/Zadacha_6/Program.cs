Console.Write("Введите натуральное число: ");
int i = int.Parse(Console.ReadLine());

if (i%2 == 0)
{
    Console.WriteLine($"Число {i} чётное");
}
else
{
    Console.WriteLine($"Число {i} нечётное");
}