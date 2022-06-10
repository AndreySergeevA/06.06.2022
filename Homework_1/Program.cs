/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
            if (numberInt <= 0) Console.WriteLine("Введите число больше нуля");
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

int NumbersSumm(int numberN,int numberM)
{
    if (numberN >= numberM)
    return numberM;
    numberM--;
    return numberM+1 + NumbersSumm(numberN, numberM);
}

int numberN = NumberInput("числоN");
int numberM = NumberInput("числоM");

int result = NumbersSumm(numberN, numberM); 
Console.WriteLine(result);
