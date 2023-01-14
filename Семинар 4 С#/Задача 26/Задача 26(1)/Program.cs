Console.WriteLine(" Введите число: ");
string number = Console.ReadLine();

if(int.TryParse(number, out int A))
{
 
    Console.WriteLine(number.Length);
}
else
{
    Console.WriteLine(" Ошибка ");
}



