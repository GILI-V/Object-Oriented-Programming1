
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> values = new List<double> { 1, 2, 3, 4 };
        OperationTable<double> table =
            new OperationTable<double>(values, values, (x, y) => x + y);
        table.Print();
    }
}
