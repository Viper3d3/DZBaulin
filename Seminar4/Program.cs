﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("N:");
int N = Convert.ToInt32(Console.ReadLine());
int chetN = 1;

while (chetN <= N)
{

    if(chetN == 0)
 {
    Console.WriteLine("Четные числа :" + chetN);
 }
    if (chetN % 2 == 0)
 {
    Console.WriteLine(chetN);
 }
chetN +=1;
}


