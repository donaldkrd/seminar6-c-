Console.Clear();

Console.Write("Введите число М и потом такое же число произвольных чисел:");
int numberM = int.Parse(Console.ReadLine()!);
int counter = 0;

for (int i = 0; i < numberM; i++)
{
    int thisNumber = int.Parse(Console.ReadLine()!);
    if (thisNumber > 0)
    {
        counter ++;
    }
    
}
Console.WriteLine($"Количество положительных чисел: {counter}");
