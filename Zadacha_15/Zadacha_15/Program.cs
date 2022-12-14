// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());

if (day>7 || day<1)
{
    Console.WriteLine("Вы ввели неверное число. Попробуйте ещё раз.");
    return;
}
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}