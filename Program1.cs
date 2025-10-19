Console.WriteLine("Введите n");
double n = Convert.ToDouble(Console.ReadLine());
double i = 0;
while (i < n)
{
    if (i % 3 == 0 && i % 5 !=0)
    {
        i++;
    } 
}
Console.WriteLine(i);