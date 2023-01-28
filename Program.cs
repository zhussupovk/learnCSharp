// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[4];

fillArray(arr);

printArray(arr);

diff(arr);
void fillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 101);
    }
}
void printArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]}  ");
    }
    System.Console.WriteLine();
}
void diff(int[] arr)
{
    int mx = arr[0];
    int mn = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > mx)
        {
            mx = arr[i];
        }
        if (arr[i] < mn)
        {
            mn = arr[i];
        }
    }
    System.Console.WriteLine($"max={mx}  ;  min={mn}  ;  diff={mx - mn}");
}