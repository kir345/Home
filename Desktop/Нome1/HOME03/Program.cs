// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.Clear();
Console.WriteLine("Введите число: ");
int num1 = 22;
int num2 = 3;
int num3 = 9;

int max = num1;

if (num2 > max)
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}
Console.WriteLine("Наибольшее из введенных чисел -> " + max);
