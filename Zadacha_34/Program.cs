//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

Console.Write ("Введите длину массива: ");
int length=int.Parse(Console.ReadLine()!);//ввод длины массива
int[] array = GetArray(length);
Console.WriteLine (GetArrayAsString(array));
Console.WriteLine ($"Количество четных элементов в массиве равно: {GetNumbers(array)}");

int[] GetArray (int length) // создание и заполнение массива
{
    const int minValue = 100;
    const int maxValue = 999;
    int[] array = new int[length];
    Random random = new Random ();
    for (int i=0; i<array.Length; i++) array[i] = random.Next(minValue,maxValue+1);
    return array;
}
string GetArrayAsString (int[] array) //вывод массива в строку
{
    string s = string.Empty;
    foreach (var item in array) s+=$"{item} ";
    return s;
}    

int GetNumbers (int[] array)
{
    int kol = 0;
    for (int i=0; i<array.Length;i++)
    {
        if (array[i]%2 == 0)
            {
                kol++;
            }
    }
    return kol;
}