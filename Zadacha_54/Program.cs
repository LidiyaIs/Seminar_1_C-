// Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void OrderRow(int [,] mass, int index)
{
int temp;
for (int i=0; i < mass.GetLength(1)-1; i++)
    {
        for (int j=i+1; j < mass.GetLength(1); j++)
        {
            if (mass[index,i]<mass[index,j])
            {
                temp=mass[index,i];
                mass[index,i]=mass[index,j];
                mass[index,j]=temp;
            }
        }
    }
}

int [,] Order(int[,] massive)
{
    for (int i=0; i < massive.GetLength(0); i++) OrderRow(massive, i);
    return massive;
}

int[,] array = new int [5,6];
FillArray (array);
PrintArray (array);
Console.WriteLine();
Order(array);
PrintArray(array);