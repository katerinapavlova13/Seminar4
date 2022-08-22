// Напишите цикл, который 
//принимает на вход два числа (А и B)
// и возводит число А в натуральную степень В.
//3,5 - 243
//2,4 - 16

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 == 0) Console.Write($"{1}"); return;

int number = num1;
int count = 1;

while (count < num2)
{
    number = number * num1;
    count++;
}

Console.Write($"Первое число в степени второго числа -> {number}");



