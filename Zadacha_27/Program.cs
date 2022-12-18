// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

int SummaChisel (int a)
{
int x = a;
int summa = 0;
while (x!=0)
{
    summa = summa+x%10;
    x= x/10;
}
return summa;
}

Console.Write ("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine ()!);

int Sum = SummaChisel (number);

Console.WriteLine("Сумма цифр числа " + number+ " равна " + Sum);