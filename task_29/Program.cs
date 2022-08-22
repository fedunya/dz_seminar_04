// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void PrintArray(int[] array)
{
    int lenght = array.Length;
    Console.Write($"[{array[1]}");
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
int[] CreateArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"Введите {i+1}-е число массива: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
var arr = CreateArray(8);
Console.WriteLine();
PrintArray(arr);
