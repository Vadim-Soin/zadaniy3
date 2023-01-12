Console.WriteLine("Введите число");
int num  = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < num + 1; i++)
{
    Console.Write($"{i * i * i}, ");
}
Console.WriteLine(" ");
