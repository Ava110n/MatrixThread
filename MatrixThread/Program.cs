﻿using System;

namespace MatrixThread // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        Random r = new Random();

        static void Main(string[] args)
        {
            int n = 2, m = 3, k =4;
            int[,] firstMatrix = new int[n, m];
            int[,] secondMatrix = new int[m, k];
            int[,] resultMatrix = new int[n, k];


        }

        void Insert(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = r.Next(20);
                }
            }
        }

        void showMatrix(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    System.Console.Write(matrix[i,j]);
                    System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}