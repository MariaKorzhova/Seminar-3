System.Console.WriteLine("Введите число от 1 до бесконечности: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine("Число меньше 1");
}
else for (int i = 1; i <= n; i++)
{
    System.Console.Write($"{i * i * i} ");
}

