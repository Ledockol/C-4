//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите массив");

int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
} 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}\t");
    }
}

int[] arr = CreateArray();
PrintArray(arr);
