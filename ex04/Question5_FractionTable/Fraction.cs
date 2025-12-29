
using System;

public class Fraction
{
    public int Numerator { get; }
    public int Denominator { get; }

    public Fraction(int n, int d)
    {
        int gcd = GCD(Math.Abs(n), Math.Abs(d));
        Numerator = n / gcd;
        Denominator = d / gcd;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    public static Fraction operator +(Fraction a, Fraction b) =>
        new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator,
                     a.Denominator * b.Denominator);

    public override string ToString() => $"{Numerator}/{Denominator}";
}
