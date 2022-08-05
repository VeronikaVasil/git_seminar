//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.//
Console.Write("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());

int negativeNumber = number * (-1);

while (negativeNumber <= number) //пока несправедливо условие
{
    Console.WriteLine(negativeNumber);
    negativeNumber++;
}

