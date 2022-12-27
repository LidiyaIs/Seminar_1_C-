//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.Write ("Введите длину массива (целое число): ");
int length = int.Parse(Console.ReadLine()!);

Console.Write("Введите нижнюю границу массива (целое число): ");
int firstBoard = ReadInt();

Console.Write("Введите верхнюю границу массива (целое число): ");
int secondBoard = ReadInt();

double[] array = GetArray(length, firstBoard, secondBoard);
Console.WriteLine (GetArrayAsString(array));

Console.WriteLine ("Разница между мин и макс элементами массива равна: " + Math.Round((GetMax(array) - GetMin(array)),2));

int ReadInt()
{
    string s = Console.ReadLine(); 
    if (int.TryParse (s, out int i)) return i;

    return -1;
}

double[] GetArray(int length, int minValueInt, int maxValueInt) // создание и заполнение массива вещ.числами
{
    double[] array = new double[length];
    Random random = new Random ();
    for (int i=0; i<array.Length; i++) array[i] = Math.Round(random.Next(minValueInt, maxValueInt+1)+random.NextDouble(),2);
    return array;
}
string GetArrayAsString (double[] array) //вывод массива в строку
{
    string s = string.Empty;
    foreach (var item in array) s+=$"{item} ";
    return s;
}    
double GetMin (double[] array)
{
  double  min = array[0];
    for (int i=1; i<array.Length;i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double GetMax(double[] array)
{
    double  max = array[0];
    for (int i=1; i<array.Length;i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}