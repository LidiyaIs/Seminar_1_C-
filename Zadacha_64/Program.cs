// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

void PrintNumbers(int n)
{
    Console.Write(n + " ");
    if (n != 1) PrintNumbers(n - 1);
}
Console.Write("Введите натуральное число:");
int number = int.Parse(Console.ReadLine());

PrintNumbers(number);