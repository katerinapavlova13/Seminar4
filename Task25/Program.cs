// Напишите цикл, который 
//принимает на вход два числа (А и B)
// и возводит число А в натуральную степень В.
//3,5 - 243
//2,4 - 16

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B == 0)
{
    Console.Write($"{1}");
    return;
}

int number = A;
int count = 1;
while (count < B)
{
    number = number * A;
    count++;
}

Console.Write($"{A} ^ {B} = {number}");





