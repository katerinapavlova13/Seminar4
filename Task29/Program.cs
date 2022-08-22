// Напишите программу, которая
// задаёт массив из 8 элементов, заполненный псевдослучайными числами и 
//выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.Write("Введите размер массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] RandArray(int len) 
{
    int[] arrays = new int[len]; 
    int i = 0;

    for (i = 0; i < arrays.Length; i++) 
        {
            arrays[i] = new Random().Next(1, 1000);
        }
    return arrays; 
}

int[] res = RandArray(lenght); 

void PrintArray(int[] res1) 
{
    Console.Write($"["); 
    for (int i = 0; i < res1.Length; i++) 
    {
        Console.Write($"{res1[i]},"); 
    }
    Console.Write($"{res1[res1.Length -1]}]"); 
}
PrintArray(res);