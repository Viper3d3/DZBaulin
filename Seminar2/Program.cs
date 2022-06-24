//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число :");
int num3 = Convert.ToInt32(Console.ReadLine());

 if(num1 > num2)
{
    if(num1>num3)
    {
        Console.WriteLine($"Число мах: {num1}");  
    }
}
else if(num2 > num3)
{
    Console.WriteLine($"Число мах: {num2}");
}
else
{
    Console.WriteLine($"Число мах: {num3}");
}    
