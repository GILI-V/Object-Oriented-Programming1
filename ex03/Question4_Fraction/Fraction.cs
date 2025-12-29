
using System;

public class Fraction
{
    public int Numerator { get; }
    public int Denominator { get; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero");

        int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
        Numerator = numerator / gcd;
        Denominator = denominator / gcd;
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

    public static Fraction operator -(Fraction a, Fraction b) =>
        new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator,
                     a.Denominator * b.Denominator);

    public static Fraction operator *(Fraction a, Fraction b) =>
        new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

    public static Fraction operator /(Fraction a, Fraction b) =>
        new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);

    public override string ToString() => $"{Numerator}/{Denominator}";
}
