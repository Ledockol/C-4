//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Write("Введи число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
while (Num > 0)
{
int NumSecond = Num % 10;
Num = Num / 10;
Sum = Sum + NumSecond;
}
Console.WriteLine($"сумма цифр в числе равна:{Sum}");

 