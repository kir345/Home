// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int num = ReadInt("Введите число: ");
int len = NumberLen(num);
SumNumbers (num, len);

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int s)
{
    int index = 0;
    while (s > 0)
    {
        s /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int a, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += a%10;
        a /= 10;
    }
    Console.WriteLine(sum);
}
