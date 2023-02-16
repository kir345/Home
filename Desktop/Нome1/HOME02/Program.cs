// Напишите программу, которая на вход принимает число (N), на выходе показывает все четные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число: ");
int m = 1;
bool not = true;
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные числа от 1 до " + num);
while (m <= num)
{
    if(m % 2 != 1)
    {
        Console.Write(m + ", ");
        not = false;
    }
    m++;
}

if (not)
{
    Console.WriteLine("Нет четных чисел!");
}






