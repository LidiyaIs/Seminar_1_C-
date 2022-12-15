// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите 5-значное число");
string n = Console.ReadLine();

if (n.Length == 5)
{
    if (n[0] == n[n.Length - 1] && n[1] == n[n.Length - 2])
    {
        Console.WriteLine($"Число {n} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {n} НЕ палиндром");
    }
}
else Console.WriteLine ("Вы ввели не 5-значное число");