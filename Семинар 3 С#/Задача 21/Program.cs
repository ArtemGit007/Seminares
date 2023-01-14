// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространств


Console.WriteLine("введите Х-координату 1 точки: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y-координату 1 точки: ");
double Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите Х-координату второй точки: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y-координату 2 точки: ");
double Y2 = Convert.ToInt32(Console.ReadLine());

// Расстояние
double rast = Math.Round(Math.Sqrt(Math.Pow(X1 - X2 , 2) + Math.Pow(Y1 - Y2 , 2)), 1);

Console.WriteLine("Расстояние между точками: " + rast);