// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Powr(int num1, int num2)
{
    int count = 1;
  
    for (int i = 1; i<=num2; i++)
    {
        count*=num1;

    }
    return count;
}
Console.Write("Введите число A:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"A в степени B = {Powr(a,b)}");