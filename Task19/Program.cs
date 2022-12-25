// int number = Convert.ToInt32(Console.ReadLine());
int number =12821;
int a = number, b = 0, temple;
while (number != 0)
{
    temple = number % 10;
    number = number / 10;
    b = b * 10 + temple;
}
if (a == b)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}
