// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
long SumDigits(long num)
{
    long result = 0;
    while (num != 0)
    {
        long digit = num % 10;
        result = result + digit;
        num = num / 10;
    }
    return result;
}

for(;;)
{
    Console.Write("Введите целое число (Для выхода введите Y): ");
    var numberString = Console.ReadLine()!;
    if(numberString.Equals("Y"))
        break;
    if (long.TryParse(numberString, out var number))
    {
        number = Math.Abs(number);
        long sum = SumDigits(number);
        Console.WriteLine("Сумма цифр в числе равна: " + sum);
    }
    else
    {
        Console.WriteLine("Введено не число!");
    }
}
