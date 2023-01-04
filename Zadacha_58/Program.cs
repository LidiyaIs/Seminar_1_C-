// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray (int[,] mass) //функция заполнения массива
{
      for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            mass[i,j]=new Random().Next(-2,2);
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

int [,] Multiplication (int [,] mass1, int [,] mass2)
{
  int [,] massResult=new int[mass1.GetLength(0), mass1.GetLength(1)];
  for (int i=0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            massResult[i, j] = mass1[i, j] * mass2[i, j];
        }
        
    }
return massResult;    
}
    
int[,] arrayOne = new int [3,4];
int[,] arrayTwo = new int [3,4];
FillArray (arrayOne);
Console.WriteLine("Первая матрица: ");
PrintArray (arrayOne);
Console.WriteLine();
FillArray (arrayTwo);
Console.WriteLine("Вторая матрица: ");
PrintArray (arrayTwo);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(Multiplication(arrayOne, arrayTwo));