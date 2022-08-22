// Напишите программу, которая 
//принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
int result = SumNumber(number);
Console.Write($"Сумма цифр числа:{number} -> {result}");