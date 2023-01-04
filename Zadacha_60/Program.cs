// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray (int[,,] mass) //функция заполнения массива
{
    List<int> allElements = new List<int>();

    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                mass[i, j, k] = new Random().Next(10, 100);
                while (allElements.Contains(mass[i, j, k])) mass[i, j, k] = new Random().Next(10, 100);
                allElements.Add(mass[i, j, k]);
            }   
                  
        }
    }
}

void PrintArray (int[,,] mass) //функция вывода массива
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            for (int k=0; k < mass.GetLength(2); k++) Console.Write($"{mass[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

    
int[,,] array3D = new int [3,2,2];
FillArray (array3D);
PrintArray (array3D);