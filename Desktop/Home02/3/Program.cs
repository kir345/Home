// Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = Int32.Parse(Console.ReadLine());
if(a <= 999)
{
    a = (a % 100 / 10);
    Console.WriteLine(a);
    
}

   