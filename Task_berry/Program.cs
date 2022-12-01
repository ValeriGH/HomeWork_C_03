Console.Clear();
Console.Write("Введите количество кустов: ");
int n = int.Parse(Console.ReadLine());
while (n < 3 || n > 10) // до 1000
{
    Console.Write("Ошибка!\nВведите количество кустов: ");
    n = int.Parse(Console.ReadLine());
}

int[] berry = new int[n];
for (int i = 0; i < n; i++)
{
    berry[i] = new Random().Next(1, 11); // до 1001
    Console.WriteLine(berry[i]);
}

int max_berry = 0;
int sum = 0;
for (int i = 1; i < n - 1; i++)
{
    sum = berry[i - 1] + berry[i] + berry[i + 1];
    if (sum > max_berry)
        max_berry = sum;
}

if (berry[0] + berry[1] + berry[n - 1] > max_berry)
    max_berry = berry[0] + berry[1] + berry[n - 1];
if (berry[n - 2] + berry[n - 1] + berry[0] > max_berry)
    max_berry = berry[n - 2] + berry[n - 1] + berry[0];

Console.WriteLine($"Максимальное количество ягод: {max_berry}");