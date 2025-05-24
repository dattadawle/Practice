using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = 10;
        int center = 11;

        // Step 1: Generate the edges for the star tree
        List<(int a, int b)> edges = new List<(int, int)>();
        for (int i = 1; i <= N; i++)
        {
            if (i == center)
                continue;
            edges.Add((i, center));
        }

        // Step 2: Check if the given tree is a star tree
        // We'll count the degree of each node
        Dictionary<int, int> degree = new Dictionary<int, int>();
        for (int i = 1; i <= N; i++)
        {
            degree[i] = 0;
        }

        foreach (var edge in edges)
        {
            degree[edge.a]++;
            degree[edge.b]++;
        }

        // Step 3: Check for exactly one node with degree = N - 1
        bool isStar = false;
        foreach (var kvp in degree)
        {
            if (kvp.Value == N - 1)
            {
                isStar = true;
                break;
            }
        }

        // Step 4: Output result
        Console.WriteLine(isStar ? "Yes" : "No");
        Console.ReadLine();
    }
}