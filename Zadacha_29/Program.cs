// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray (int [] massive, int x, int y)
{
for (int index=0; index<massive.Length; index++) massive[index]=new Random ().Next(x,y+1);
}


void PrintArray (int [] collection)
{
for (int index=0; index<collection.Length; index++) Console.Write(collection [index]+" ");
}

int [] Array = new int [8]; //создали массив из восьми элементов

Console.WriteLine ("Введите интервал значений элементов массива");
Console.Write ("Начальное значение: ");
int a=int.Parse(Console.ReadLine()!);
Console.Write ("Конечное значение: ");
int b=int.Parse(Console.ReadLine()!);

FillArray (Array, a, b); //заполнение массива значениями из заданного интервала
PrintArray (Array);   //Вывод массива на экран