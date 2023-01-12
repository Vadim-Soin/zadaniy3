Console.WriteLine("Введите скольки мерное пространство");
int d = Convert.ToInt32(Console.ReadLine());
int[] toch1 = new int[d];
int[] toch2 = new int[d];

//2 for по (d) раза

for (int i = 0; i < d; i++)
{
    Console.WriteLine($"Введите координату {i + 1} у первой точки");
    int num = Convert.ToInt32(Console.ReadLine());
    toch1 [i] = num;
}

for (int i = 0; i < d; i++)
{
    Console.WriteLine($"Введите координату {i + 1} у второй точки");
    int num = Convert.ToInt32(Console.ReadLine());
    toch2 [i] = num;
}

double Dist = Math.Sqrt(Math.Pow((toch2 [0] - toch1 [0]), 2) + Math.Pow((toch2 [1] - toch1 [1]), 2) + Math.Pow((toch2 [2] - toch1 [2]), 2));

Console.WriteLine($"Расстояние равно {Dist}");


//Console.WriteLine();

// for (int i = 0; i < d; i++)
// {
//     Console.Write($"{toch1[i]}, ");
// }

// Console.WriteLine();

// for (int i = 0; i < d; i++)
// {
//     Console.Write($"{toch2[i]}, ");
// }

//Console.WriteLine();
