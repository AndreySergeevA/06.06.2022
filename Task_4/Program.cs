/* 
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. 
A = 3; B = 5 -> 243 (3⁵) 
A = 2; B = 3 -> 8 
 
 
*/ 
Console.WriteLine("Введите первое число A: "); 
int a = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите второе число B: "); 
int b = int.Parse(Console.ReadLine()); 
int result = PowResult(a,b); 
 
int PowResult (int a, int b) 
{ 
    if (b == 1) 
    return a;  
    b--; 
    return a * PowResult(a,b); 
} 
Console.Write(result);