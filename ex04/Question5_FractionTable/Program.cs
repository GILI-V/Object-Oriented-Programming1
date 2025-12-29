
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Fraction> values = new List<Fraction>();
        for (int i = 1; i <= 12; i++)
            values.Add(new Fraction(i, 12));

        OperationTable<Fraction> table =
            new OperationTable<Fraction>(values, values, (x, y) => x + y);

        table.Print();
    }
}
