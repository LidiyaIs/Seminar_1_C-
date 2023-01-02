// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray (double[,] mass) //функция заполнения массива
{
      for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            mass[i,j]= Math.Round(new Random().Next(-15,16) + new Random().NextDouble(),2);
        }
    }

}

void PrintArray (double[,] mass) //функция вывода массива
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i,j]} ");
        }
        Console.WriteLine ();
    }

}

Console.WriteLine("Введите размер двумерного массива MxN:");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double [m,n];
FillArray (array);
PrintArray (array);