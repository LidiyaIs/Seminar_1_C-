// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] array = new int[4, 4]; //{ { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
FillArray (array);
PrintArray (array);

void FillArray (int[,] matr)
{
    int item=1;
    int i=0;
    int j=0;
    while (item<=matr.GetLength(0)*matr.GetLength(1))
    {
        matr[i,j]=item;
        item++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1) j++;
         else if (i < j && i + j >= matr.GetLength(0) - 1) i++;
            else if (i >= j && i + j > matr.GetLength(1) - 1) j--;
                else i--;
    }
}


void PrintArray (int[,] mass) //функция вывода массива
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            if (mass[i,j]<10) Console.Write($"0{mass[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine ();
    }
}