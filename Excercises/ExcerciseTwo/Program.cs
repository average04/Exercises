
while (true)
{
    Console.Write("Enter number (0 to exit): ");
    int n = int.Parse(Console.ReadLine()!);

    if (n == 0) break;
    if (n == 1) Console.WriteLine("1 is neither prime nor composite.");
    else if (IsPrime(n))
        Console.WriteLine("Number is prime");
    else Console.WriteLine("Number is not prime");
}

bool IsPrime(int number)
{
    if (number == 1) return false;
    if (number == 2) return true;

    int limit = (int)Math.Ceiling(Math.Sqrt(number));

    for (int i = 2; i <= limit; i++)
    {
        if (number % i == 0) return false;
    }

    return true;
}
