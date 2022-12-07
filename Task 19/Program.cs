Console.WriteLine("Введите пятизначное число");
string n = Convert.ToString(Console.ReadLine());
if (n.Length == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
        System.Console.WriteLine($"Число {n} является палиндромом");
    }
    else 
    {
        System.Console.WriteLine($"Число {n} НЕ является палиндромом");
    }
}
else 
{
    System.Console.WriteLine($"Число {n} НЕ является пятизначным");
}
