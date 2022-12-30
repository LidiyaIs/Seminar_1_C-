// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 или 1, -7, 567, 89, 223-> 3

Console.Write ("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

int[] massive = GetArray(m);
Console.WriteLine ($"Ваши числа: {GetArrayAsString(massive)}");

Console.WriteLine ("Количество чисел больше 0 равно: "+ (Count (massive)));

int[] GetArray (int length) // функция ввода массива
{
    int[] array = new int [length];
    for (int i=0;i<array.Length;i++)
    {
        Console.Write($"Введите {i+1}-ое число:");
        array[i]=int.Parse(Console.ReadLine());
    }    
    return array;
}

string GetArrayAsString (int[] array) //вывод массива в строку
{
    string s = string.Empty;
    foreach (var item in array) s+=$"{item} ";
    return s;
}    

int Count (int[] array)
{
    int kol = 0;
    for (int i=0;i<array.Length;i++) 
    {
        if (array[i]>0) kol++;
        
    }
    return kol;
}