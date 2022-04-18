Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num / 100 > 0) 
{
    Console.WriteLine($"Третьей цифрой числа {num} является цифра {num / 100 % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}