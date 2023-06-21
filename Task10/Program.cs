Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());
if(num<100 || num>999)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
int num1 = num/10;
int num2 = num1%10;
Console.WriteLine($"Вторая цифра числа {num} - {num2}");