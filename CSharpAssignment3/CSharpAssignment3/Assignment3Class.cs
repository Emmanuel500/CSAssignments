using System;

public class Assignment3Class
{
    //1) Reverse Array
    public int[] GenerateNumbers()
    {
        int[] numbers = new int[10];
        Console.WriteLine("Type 10 integers:");
        for (int x = 0; x < numbers.Length; x++)
        {
            numbers[x] = Convert.ToInt32(Console.ReadLine());
        }
        return numbers;
    }
    public void Reverse(int[] numb)
    {
        Array.Reverse(numb);
    }
    public void PrintNumbers(int[] numb)
    {
        foreach (int num in numb)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("");
    }

    //2) Fibonacci sequence (Recursive)
    public int FibonacciNumber(int fibNumber)
    {
        if (fibNumber == 1 || fibNumber == 2)
        {
            return 1;
        }
        else
        {
            return FibonacciNumber(fibNumber - 1) + FibonacciNumber(fibNumber - 2);
        }
    }

}

//7) Color & Ball class
public class Color
{
    //Fields
    private byte red, green, blue, alpha;
    //Constructor
    public Color(byte r, byte g, byte b, byte a)
    {
        red = r;
        green = g;
        blue = b;
        alpha = a;
    }
    public Color(byte r, byte g, byte b)
    {
        red = r;
        green = g;
        blue = b;
        alpha = 255;
    }
    //Methods
    public double GetGrayScale()
    {
        return (red + green + blue) / 3;
    }
    //Properties
    public byte Red { get { return red; } set { red = value; } }
    public byte Green { get { return green; } set { green = value; } }
    public byte Blue { get { return blue; } set { blue = value;} }
    public byte Alpha { get { return alpha; } set { alpha = value; } }
}

public class Ball
{
    //Fields
    int size;
    int throwCount = 0;
    Color color;
    //Constructor
    public Ball(int size)
    {
        this.size = size;
    }
    public Ball(int size, byte r, byte g, byte b)
    {
        this.size = size;
        color = new Color(r, g, b);
    }
    //Methods
    public void Pop()
    {
        size = 0;
    }
    public void Throw()
    {
        if (size != 0)
        {
            throwCount++;
        }
    }
    //Properties
    public int ThrownCount { get { return throwCount; } }
}