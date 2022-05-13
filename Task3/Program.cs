Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.Write("Понедельник, рабочий день");
}
if (number == 2)
{
    Console.Write("Вторник, рабочий день");
}
if (number == 3)
{
    Console.Write("Среда, рабочий день");
}
if (number == 4)
{
    Console.Write("Четверг, рабочий день");
}
if (number == 5)
{
    Console.Write("Пятница, рабочий день");
}
else (number == 6)
{
    Console.Write("Суббота - выходной!");
}
else (number == 7)
{
    Console.Write("Воскресенье - выходной!");
}
