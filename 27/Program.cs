// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int num)// Считает сумму цифр в числе
{
    int sum=0;
    while(num>=1)
    {
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}

Console.Write("Введите целое число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе: {Sum(number)}");