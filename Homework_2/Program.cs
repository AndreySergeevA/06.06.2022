/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/


int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int number =0;
    while (isInputInt)
    {
        Console.Write($"Введите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            if (numberInt < 0) Console.WriteLine("Введите положительное число");
            else
            {
                number = numberInt;
                isInputInt = false;
            }
            
        }
        else 
            Console.WriteLine("Ввели не число");
    }
    return number;
}

int Ackermann(int m, int n)
{
    if (m == 0)
    return n + 1;
    if (m != 0 && n == 0)
    return Ackermann(m - 1, 1);
    if (m > 0 && n > 0)
    return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(m, n);
}   
int m = NumberInput("число m");
int n = NumberInput("число n");
long acermann = Ackermann(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {acermann}");