Console.WriteLine("Введите n");
double n = Convert.ToDouble(Console.ReadLine());
for (double i = 0; i < n; i++)
{
    if (i % 3 == 0 && i % 5 !=0)
    {
        Console.WriteLine(i);
    }
}
