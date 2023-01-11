Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int a = num / 10000;
int b = num / 1000 % 10;
int c = num / 10 % 10;
int d = num % 10;

if ( a == d & b == c ) Console.WriteLine("Число является палиндромом");

else Console.WriteLine("Число не является палиндромом");