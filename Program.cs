//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (num % 7 == 0 || (num + 1) % 7 == 0)
{
    Console.WriteLine("Выходной!!!");
}
else
{
    Console.WriteLine("Рабочий день");
}
