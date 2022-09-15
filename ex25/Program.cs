//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень");
int NumDegree = Convert.ToInt32(Console.ReadLine());

GetDegree(Num, NumDegree);

void GetDegree(int A, int B)
{
        double result = Math.Pow(A, B);
    if(B >= 0)
    {
        Console.WriteLine($"{result}");
    }
    else 
    {
        Console.WriteLine("Степень не натуральое число");
    }
}