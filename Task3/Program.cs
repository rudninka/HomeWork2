Console.Write("Введите номер дня недели: ");
int dayNum = int.Parse(Console.ReadLine());
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string result = "";

if (dayNum > 5) 
{
     Console.WriteLine("выходной день");
}
else
{
    Console.WriteLine("рабочий день");
}
System.Console.WriteLine($"{dayNum}-й день недели - это {Days[dayNum - 1]}{result}");
