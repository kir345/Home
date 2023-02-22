// Написать программу, которая принимает на вход пятизначное число и проверяет, является 
// ли оно палиндроном.
// 14212 -> нет
// 12821 -> да 
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;

if (len == 5)
{
    if(num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} = да");
    }
else 
    {
        Console.WriteLine($"{num} = нет");
    }
}
