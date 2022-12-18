// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
double Degree (double number, int stepen)
{
    double result = 1;
   for (int i=1; i<=stepen; i++)
   {
    result = result*number; 
   }   
    return result;
}

Console.WriteLine ("Введите число и степень для возведения (>0)");
Console.Write ("Число: ");
double a = int.Parse(Console.ReadLine ()!);
Console.Write ("Степень: ");
int b = int.Parse(Console.ReadLine ()!);

double answer = Degree (a,b);

Console.WriteLine(a +" в степени "+ b + " равно " + answer);