// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)
Console.Clear();
Console.WriteLine("Enter the number: ");
int N = Convert.ToInt32(Console.ReadLine());
int evenNumber = 1;
Console.Write("Even numbers: ");
if (N <= 2)                             //На случай если ввели число меньше 2 (либо 1, либо 2, так как в условии задачи ОТ 1 не включая N)
{
    Console.Write("No even numbers!");
}
while (evenNumber < N)
{
    if (evenNumber % 2 == 0)
    {
        Console.Write($"{evenNumber} ");
    }
    evenNumber++;
}
