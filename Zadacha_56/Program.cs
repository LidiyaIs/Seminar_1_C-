// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumRow(int [,] mass, int index)
{
int sum=0;
for (int i=0; i < mass.GetLength(1); i++) sum+=mass[index,i];
return sum;    
}
    
int CompareSums(int[,] massive)
{
    int item=0;
    int summa1=SumRow(massive,0);
    for (int i=1; i < massive.GetLength(0); i++)
    {
        if (SumRow(massive,i)<summa1)
        {
            summa1=SumRow(massive,i);
            item=i;
        }
    }
return item;
}

int[,] array = new int [3,4];
FillArray (array);
PrintArray (array);
Console.WriteLine();
Console.WriteLine($"строка с минимальной суммой элементов № {CompareSums(array)+1}");//ПРОШУ УЧЕСТЬ!
//результат функциии специально увеличен на 1 для удобства восприятия пользователя, а не так, как обозначается в массиве