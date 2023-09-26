using System;
using System.Collections.Generic;
using System.Text;

static void Solve()
{
    
}
// main 
FastReader fr = new FastReader();
PrintWritter pw = new PrintWritter();
var (a,b,c) = fr.ReadTriple<double>();
var (d, e) = fr.ReadPair<int>();
pw.PrintLine(a+" "+b+" "+c+" "+d+" "+e);


class Number
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
class Scanner
{
    private string[] _line;
    private int _index;
    private const char Separator = ' ';
 
    public Scanner()
    {
        _line = new string[0];
        _index = 0;
    }
 
    public string Next()
    {
        if (_index >= _line.Length)
        {
            string s;
            do
            {
                s = Console.ReadLine();
            } while (s.Length == 0);
 
            _line = s.Split(Separator);
            _index = 0;
        }
 
        return _line[_index++];
    }
    public string ReadLine()
    {
        _index = _line.Length;
        return Console.ReadLine();
    }
    public int NextInt() => int.Parse(Next());
    public long NextLong() => long.Parse(Next());
    public double NextDouble() => double.Parse(Next());
    public decimal NextDecimal() => decimal.Parse(Next());
    public char NextChar() => Next()[0];
    public char[] NextCharArray() => Next().ToCharArray();
    public string[] Array()
    {
        string s = Console.ReadLine();
        _line = s.Length == 0 ? new string[0] : s.Split(Separator);
        _index = _line.Length;
        return _line;
    }
    public int[] IntArray() => Array().AsParallel().Select(int.Parse).ToArray();
    public long[] LongArray() => Array().AsParallel().Select(long.Parse).ToArray();
    public double[] DoubleArray() => Array().AsParallel().Select(double.Parse).ToArray();
    public decimal[] DecimalArray() => Array().AsParallel().Select(decimal.Parse).ToArray();
    public char[] CharArray() => Array().AsParallel().Select(char.Parse).ToArray();
}
class FastReader
{
    public int ReadInt()
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
    public double ReadDouble()
    {
        return double.Parse(Console.ReadLine());
    }
    public long ReadLong()
    {
        return long.Parse(Console.ReadLine());
    }
    public char ReadChar()
    {
        return char.Parse(Console.ReadLine());
    }
    public string ReadString()
    {
        return Console.ReadLine();
    }   
    public int[] InputArrayInt(int len = -1)
    {
        if (len == -1)
            len = ReadInt();
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
    public long[] InputArrayLong(int len = -1)
    {
        if (len == -1)
            len = ReadInt();
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
    public double[] InputArrayDouble(int len =-1)
    {
        if (len == -1)
            len = ReadInt();
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
    public char[] InputArrayChar(int len = -1)
    {
        if (len == -1)
            len = ReadInt();
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
    public (T, T) ReadPair<T>()
    {
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return ((T)Conv<T>(s[0]), (T)Conv<T>(s[1]));
    }
    public (T, T, T) ReadTriple<T>()
    {
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return ((T)Conv<T>(s[0]), (T)Conv<T>(s[1]), (T)Conv<T>(s[2]));
    }
    public T Conv<T>(string s)
    {
        if (typeof(T) == typeof(int)) return (T)(object)Convert.ToInt32(s);
        if (typeof(T) == typeof(uint)) return (T)(object)Convert.ToUInt32(s);
        if (typeof(T) == typeof(long)) return (T)(object)Convert.ToInt64(s);
        if (typeof(T) == typeof(ulong)) return (T)(object)Convert.ToUInt64(s);
        if (typeof(T) == typeof(double)) return (T)(object)Convert.ToDouble(s);
        throw new NotImplementedException();
    }
}

class PrintWritter
{
    public void PrintLine<T>(T value)
    {
        Console.WriteLine(value.ToString());
    }
    public void Print<T>(T value)
    {
        Console.Write(value.ToString());
    }
    public void PrintArray<T>(T[] arr)
    {
        foreach (var item in arr)
        {
            Print(item+" ");
        }
        PrintLine("");
    }
    public void PrintList<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Print(item);
        }
        PrintLine("");
    }
    
}


