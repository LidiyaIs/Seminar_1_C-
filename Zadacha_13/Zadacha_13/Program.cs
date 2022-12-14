// Напишите программу,
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int x = number;

if (number < 100)
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}
else
{
    while (x > 1000)
    {
        x = x / 10;
    }
    //Console.WriteLine($"Число {number} {i}-значное");
    x = x % 10;
    Console.WriteLine($"У числа {number} третья цифра = {x}");
}