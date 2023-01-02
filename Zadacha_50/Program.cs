// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

 string Position (int[,] mass, int a, int b)
{
 string s2= "Такого элемента нет";   
 if ((a<mass.GetLength(0)) && (b<mass.GetLength(1)))
 {
    string s1= $"{mass[a,b]}";
    return s1;
 }
 else return s2;
}


int[,] array = new int [4,3];
FillArray (array);
Console.WriteLine("Введите позицию в двумерном массиве:");
int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine();
PrintArray (array);
Console.WriteLine();
Console.WriteLine(Position(array,x,y));