int number = Convert.
ToInt32(Console.ReadLine());
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number /= 10;
        }
        result = number % 10;
    }
    return result;
}
if (number < 100)
{
    System.
    Console.WriteLine("третьей цифры нет");
}
else
{
    System.
    Console.
    WriteLine(ThirdDigit(number));
}