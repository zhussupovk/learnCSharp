int number = Convert.ToInt32(Console.ReadLine());
int res=number%10+number/100+number%100/10;
System.Console.WriteLine(res);