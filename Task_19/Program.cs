Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 10000 || num > 100000)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int rever = 0;
int n = num;
while (n != 0)
{
    rever = rever * 10 + n % 10;
    n = n / 10;
}
//Console.WriteLine(rever);

if (num == rever)
    Console.WriteLine("Число является палиндромом");
else   
    Console.WriteLine("Число не является палиндромом");