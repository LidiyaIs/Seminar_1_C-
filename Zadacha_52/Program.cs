// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

void FillArray (int[,] mass) //функция заполнения массива
{
      for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            mass[i,j]=new Random().Next(-20,21);
        }
    }
}

void PrintArray (int[,] mass) //функция вывода массива
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

void SeverageColumn(int [,] mass)
{
    
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        int sum = 0;
        int kol = 0;
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            sum += mass[i, j];
            kol++;
        }
        double srednee = sum/kol;
        Console.Write(srednee + "; ");
    }
}

int[,] array = new int [3,4];
FillArray (array);
PrintArray (array);
Console.WriteLine();
SeverageColumn(array);