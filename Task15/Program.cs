Console.Clear();
Console.WriteLine("Введите номер дня недели");
int wd = int.Parse(Console.ReadLine());
if(wd>7 || wd<1)
{
    Console.WriteLine("Нет такого дня недели");
    return;
}
if(wd==6 || wd==7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}