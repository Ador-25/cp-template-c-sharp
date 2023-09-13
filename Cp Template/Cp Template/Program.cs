using System;
using System.Text;
static void PrintLine<T>(T value)
{
    Console.WriteLine(value.ToString());
}
static void Print<T>(T value)
{
    Console.Write(value.ToString());
}
static int ReadInt()
{
    try
    {
        String str = Console.ReadLine();
        return int.Parse(str);
    }
    catch (Exception e)
    {
        throw;
    }
}
static double ReadDouble()
{
    return double.Parse(Console.ReadLine());
}
static long ReadLong()
{
    return long.Parse(Console.ReadLine());
}
static char ReadChar()
{
    return char.Parse(Console.ReadLine());
}
static string ReadString()
{
    return Console.ReadLine();
}
static void PrintArray<T>(T[] arr)
{
    foreach (var item in arr)
    {
        Print(item+" ");
    }
    PrintLine("");
}
static void PrintList<T>(List<T> list)
{
    foreach (var item in list)
    {
        Print(item+" ");
    }
    PrintLine("");
}
static int[] InputArrayInt()
{
    int len = ReadInt();
    string input = Console.ReadLine();
    string[] integerStrings = input.Split(' '); 
    int[] numbers = new int[len];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (int.TryParse(integerStrings[i], out int number))
        {
            numbers[i] = number;
        }
        else
        {
            Console.WriteLine($"Invalid input at position {i + 1}: '{integerStrings[i]}' is not a valid integer.");
        }
    }
    return numbers;
}
static long[] InputArrayLong()
{
    int len = ReadInt();
    string input = Console.ReadLine();
    string[] integerStrings = input.Split(' '); 
    long[] numbers = new long[len];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (long.TryParse(integerStrings[i], out long number))
        {
            numbers[i] = number;
        }
        else
        {
            Console.WriteLine($"Invalid input at position {i + 1}: '{integerStrings[i]}' is not a valid integer.");
        }
    }
    return numbers;
}
static double[] InputArrayDouble()
{
    int len = ReadInt();
    string input = Console.ReadLine();
    string[] doubleStrings = input.Split(' '); 
    double[] numbers = new Double[len];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (double.TryParse(doubleStrings[i], out double number))
        {
            numbers[i] = number;
        }
        else
        {
            Console.WriteLine($"Invalid input at position {i + 1}: '{doubleStrings[i]}' is not a valid integer.");
        }
    }
    return numbers;
}
static char[] InputArrayChar()
{
    int len = ReadInt();
    string input = Console.ReadLine();
    string[] charStrings = input.Split(' '); 
    char[] numbers = new Char[len];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (char.TryParse(charStrings[i], out char number))
        {
            numbers[i] = number;
        }
        else
        {
            Console.WriteLine($"Invalid input at position {i + 1}: '{charStrings[i]}' is not a valid integer.");
        }
    }
    return numbers;
}



// main 




public class Number
{
    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static int LCM(int a, int b)
    {
        if (a == 0 || b == 0)
            return 0;

        // Calculate the LCM using the formula
        return (a / GCD(a, b)) * b;
    }
    public static List<int> SieveOfEratosthenes(int n)
    {
        bool[] isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        for (int p = 2; p * p <= n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }

        List<int> primes = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}

public class Graph
{
    private int _numberOfNodes;
    public LinkedList<int>[] _adj;

    public Graph(int numberOfNodes)
    {
        _numberOfNodes = numberOfNodes;
    }
}


