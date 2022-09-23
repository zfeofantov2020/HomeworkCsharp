// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Task number 2");

Console.WriteLine("Insert First Number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert Second Number");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    {
        Console.WriteLine($"First number {num1} greater than Second number {num2}");
    }
else if(num1 < num2)
    {
        Console.WriteLine($"Second nubmer {num2} greater then {num1} ");
    }
else
    {
        Console.WriteLine($"First number {num1} equal to Second number {num2}");
    }


