using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f = new Fraction();
        Console.WriteLine("Do you want to enter a top number? Enter 1 for Yes, 0 for No");
        int input = int.Parse(Console.ReadLine());
        if (input == 1) {
            Console.Write("Enter a top number: ");
            int top = int.Parse(Console.ReadLine());
            f.SetTop(top);
        }
        Console.WriteLine("Do you want to enter a bottom number? Enter 1 for Yes, 0 for No");
        int input2 = int.Parse(Console.ReadLine());
        if (input2 == 1) {
            Console.Write("Enter a bottom number: ");
            int bottom = int.Parse(Console.ReadLine());
            f.SetBottom(bottom);
        }
        
        // f.Fraction(top, bottom);
        f.GetTop();
        f.GetBottom();
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());


    }
    
}

public class Fraction {
    private int _top;
    private int _bottom;
    public string fract;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop() {
        return _top;
    }

    public int SetTop(int top) {
        _top = top;
        return _top;
    }

    public int GetBottom() {
        return _bottom;

    }

    public int SetBottom(int bottom) {
        _bottom = bottom;
        return _bottom;
    }

    public string GetFractionString() {
    fract = $"{_top} / {_bottom}";
    return fract;
    }

    public double GetDecimalValue() {
        return ((double)_top / (double)_bottom);
    }
}