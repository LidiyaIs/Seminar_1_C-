// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива (целое число): ");
int length = ReadInt();

Console.Write("Введите нижнюю границу массива (целое число): ");
int firstBoard = ReadInt();

Console.Write("Введите верхнюю границу массива (целое число): ");
int secondBoard = ReadInt();

int[] array = GetArray(length, firstBoard, secondBoard);// заполнение массива
Console.WriteLine (GetArrayAsString(array));// вывод массива в строку

Console.WriteLine ($" Сумма элементов на нечетных позициях равна: {GetSum(array)}");

int ReadInt()
{
    string s = Console.ReadLine();
    if (int.TryParse(s, out int i)) return i;

    return -1;
}


int [] GetArray (int length,int minValue, int maxValue) // создание и заполнение массива
{
    
    int [] array = new int [length];
    //Random random = new Random ();
    for (int i=0; i<array.Length; i++) array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}
string GetArrayAsString (int [] array) //вывод массива в строку
{
    string s = string.Empty;
    foreach (var item in array) s+=$"{item} ";
    return s;
}    
int GetSum (int [] array)
{
    int sum = 0;
    for (int i=0; i<array.Length;i++)
    {
        if ((i % 2) != 0) sum+=array[i];
    }
    return sum;
}