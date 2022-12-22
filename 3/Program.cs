void FillRandomArray(int[,] arr)
{
    Random rand = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(100, 1000);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[3,4];
FillRandomArray(array);

double[] arr = new double[array.GetLength(1)];


for(int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0;
    double count = 0;
    for(int j = 0; j < array.GetLength(0); j++)
    {
        if(array[j, i] / 100 == array[j, i] % 10)
        {
            sum += array[j, i];
            count++;
        }
    }
    if(count > 0)
    {
        arr[i] = Math.Round(sum/count, 2);
    }
    else
    {
        arr[i] = sum;
    }
}

Console.WriteLine("[{0}]", string.Join(", ", arr));