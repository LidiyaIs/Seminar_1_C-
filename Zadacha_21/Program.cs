//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine ("Введите координаты двух точек");

Console.Write("Координата первой точки на оси Оx= ");
double firstX = int.Parse (Console.ReadLine()!);
Console.Write("Координата первой точки на оси Оy= ");
double firstY = int.Parse (Console.ReadLine()!);
Console.Write("Координата первой точки на оси Оz= ");
double firstZ = int.Parse (Console.ReadLine()!);

Console.Write("Координата второй точки на оси Оx= ");
double secondX = int.Parse (Console.ReadLine()!);
Console.Write("Координата второй точки на оси Оy= ");
double secondY = int.Parse (Console.ReadLine()!);
Console.Write("Координата второй точки на оси Оz= ");
double secondZ = int.Parse (Console.ReadLine()!);

double distance = Math.Sqrt (Math.Pow((secondX-firstX),2) + Math.Pow((secondY-firstY),2) + Math.Pow((secondZ-firstZ),2));
Console.WriteLine("Расстояние между двумя точками = "+ Math.Round(distance,3));