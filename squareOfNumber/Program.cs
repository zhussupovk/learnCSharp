// System.Console.WriteLine("Введите число");
// //Readline преобразовывает в string
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(
//     $"Square of number is {number * number}");
// //конкатенация
// System.Console.WriteLine(
//     "Square of number is " + number * number);
//Вариант Ильи
System.Console.WriteLine("Введите число");
string stringNumber = Console.ReadLine()!.Trim();
int number;
while (!int.TryParse(stringNumber, out number))
{
    System.Console.WriteLine("Введите число,не строку");
    //Trim убирает пробелы с конца и сначала
    stringNumber = Console.ReadLine()!.Trim();
}
System.Console.WriteLine(
    $"Square of number is {number * number}");