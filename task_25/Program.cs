long PowAB(long a, int b)
{
    long result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
for(;;)
{
    Console.Write("Введите число A (Для выхода введите Y): ");
    var inputStringA = Console.ReadLine()!;
    if(inputStringA.Equals("Y"))
        break;
    if (long.TryParse(inputStringA, out var a))
    {
        Console.Write("Введите натуральную степень B: ");
        var inputStringB = Console.ReadLine()!;
        if(int.TryParse(inputStringB, out var b))
        {
            if(b <= 0)
            {
                Console.WriteLine("Число B должно натуральным(больше 0)!");
                continue;
            }
            var result = PowAB(a, b);
            Console.WriteLine("Число А в степени В равно: " + result);
        }
        else
        {
            Console.WriteLine("Введено не число!");
        }
    }
    else
    {
        Console.WriteLine("Введено не число!");
    }
}
