Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 100000) // Провека на корректность ввода
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int ostatok = n;
int n5 = ostatok % 10;
ostatok = ostatok / 10;
int n4 = ostatok % 10;
ostatok = ostatok / 10;
int n3 = ostatok % 10;
ostatok = ostatok / 10;
int n2 = ostatok % 10;
ostatok = ostatok / 10;
int n1 = ostatok % 10;
ostatok = ostatok / 10;

if (n1 == n5 && n2 == n4)
    Console.WriteLine("Число является палиндромом");
else   
    Console.WriteLine("Число не является палиндромом");