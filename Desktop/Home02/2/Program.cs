// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();
Console.WriteLine("Введите любое число: ");
int b = Int32.Parse(Console.ReadLine());
if (b <= 99)
{
    Console.WriteLine("Третьей цифры нет");
     return;
}
else {
    while (b > 999)
    {
        b /= 10;
    }
}
Console.WriteLine(b%10);
   

