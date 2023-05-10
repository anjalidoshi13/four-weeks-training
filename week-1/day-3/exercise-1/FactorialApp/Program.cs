class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        int n = int.Parse(Console.ReadLine());
        long fact = Fact(n);
        Console.WriteLine("factorial is {1}", n, fact);
        Console.ReadKey();
    }
    static long Fact(int n)
    {
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;

    }
}