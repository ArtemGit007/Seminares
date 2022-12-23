// Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов чмсел
// от 1 до N

Console.WriteLine("Введите число");
double number = Convert.ToInt32(Console.ReadLine());
double i = 1;

while(i <= number)
{
    double square = Math.Pow(i, 2);
    Console.Write(square + " ");
    i++ ;
}
