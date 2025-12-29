
using System;
using System.Collections.Generic;

public class OperationTable<T>
{
    public delegate T OpFunc(T x, T y);
    private T[,] table;

    public OperationTable(List<T> rows, List<T> cols, OpFunc op)
    {
        table = new T[rows.Count, cols.Count];
        for (int i = 0; i < rows.Count; i++)
            for (int j = 0; j < cols.Count; j++)
                table[i, j] = op(rows[i], cols[j]);
    }

    public void Print()
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                Console.Write(table[i, j] + "\t");
            Console.WriteLine();
        }
    }
}
