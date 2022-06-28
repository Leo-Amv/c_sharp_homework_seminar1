internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.Clear();
        Console.WriteLine("Введите первое целое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе целое число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 > number2)
        {
            Console.WriteLine($"Число {number1} - большее, а число {number2} - меньшее");
        }
        if (number1 < number2)
        {
            Console.WriteLine($"Число {number2} - большее, а число {number1} - меньшее");
        }
        else
        {
            Console.WriteLine($"Числа {number1} и {number2} - равны ");
        }

    }
}
