// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Task number 4");

Console.WriteLine("Insert First Number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert Second Number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert Third Number");

int num3 = Convert.ToInt32(Console.ReadLine());

int newMax = 0 ;

if((num1 > num2) && (num1 > num3))
    {
        newMax = num1;
        Console.WriteLine($"Greatest Number{num1} from all input numbers");
    }
else if((num2 > num3))
    {
        newMax = num2;
        Console.WriteLine($"Greatest Number {num2} from all input numbers ");
    }
else 
    {
        newMax = num3;
        Console.WriteLine($" Greatest Number {num3} from all input numbers ");
    }


