Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if(num<100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
while(num>999)
{
    num = num/10;
}
int res = num%10;
Console.WriteLine($"Третья цифра - {res}");