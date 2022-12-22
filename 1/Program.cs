void FillArray(double[,] arr)
{
    Random rand = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 10) + rand.NextDouble();
            arr[i, j] = Math.Round(arr[i, j], 2);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] array = new double[3,4];
FillArray(array);

