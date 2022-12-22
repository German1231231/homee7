void FillRandomArray(int[,] arr)
{
    Random rand = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[3,4];
FillRandomArray(array);

Console.WriteLine("Введите индекс строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a >= 0 && a < 3 && b >= 0 && b < 4)
{
    Console.Write($"[{a}, {b}] --> ");
    Console.WriteLine(array[a, b]);
}
else
{
    Console.Write($"[{a}, {b}] --> ");
    Console.WriteLine("Такого числа нет");
}

