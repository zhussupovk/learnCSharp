int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int temp=a;
for (int i = 0; i < b-1; i++)
{
    a=a*temp;
}
System.Console.WriteLine(a);