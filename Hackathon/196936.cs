using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _196936
    {
        static void ans(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int z = 0; z < t; z++)
            {
                int n = int.Parse(Console.ReadLine());
                int[,] torob = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string row = Console.ReadLine();
                    for (int j = 0; j < n; j++)
                    {
                        torob[i, j] = int.Parse(row.Split()[j]);
                    }
                }

                int[,] torobChe = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string row = Console.ReadLine();
                    for (int j = 0; j < n; j++)
                    {
                        torobChe[i, j] = int.Parse(row.Split()[j]);
                    }
                }

                output += CanMatchTables(torob, torobChe, n) ? "YES\n" : "NO\n";
            }



            Console.WriteLine(output);
            Console.ReadLine();
        }
        static bool CanMatchTables(int[,] table1, int[,] table2, int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    SwapColumns(table2, i, j,n);
                    if (TablesEqual(table1, table2, n)) return true;

                    for (int x = 0; x < n; x++)
                    {
                        for (int z = x + 1; z < n; z++)
                        {
                            SwapRows(table1, x, z,n);
                            if (TablesEqual(table1, table2, n)) return true;
                        }
                    }
                }
            }

            return false;

        }

        // Swap two rows in the table
        static void SwapRows(int[,] table, int row1, int row2 , int n)
        {
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = table[row1, i];
                table[row1, i] = table[row2, i];
                table[row2, i] = temp;
            }
        }

        // Swap two columns in the table
        static void SwapColumns(int[,] table, int col1, int col2, int n)
        {
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = table[i, col1];
                table[i, col1] = table[i, col2];
                table[i, col2] = temp;
            }
        }

        // Check if two tables are equal
        static bool TablesEqual(int[,] table1, int[,] table2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (table1[i, j] != table2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Copy table2 into table2Copy
        static void CopyTable(int[,] table2, int[,] table2Copy)
        {
            int n = table2.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table2Copy[i, j] = table2[i, j];
                }
            }
        }
    }
}
