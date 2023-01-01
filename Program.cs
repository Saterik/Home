// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < -99 || num > 99)
{
    if (num > 0) Console.WriteLine($"Третья цифра = {num.ToString()[2]}");
    else Console.WriteLine($"Третья цифра = {num.ToString()[3]}");
}
else Console.WriteLine("Третьей цифры нет");