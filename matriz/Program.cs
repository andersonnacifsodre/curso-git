﻿using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int som1 = 0;
            Console.WriteLine("Entre com o numero de linhas e colunas de uma matriz");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {

                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);

                }

            }

            Console.Write("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + ", ");
            }
            Console.WriteLine();
            Console.Write("Numero(s) Negativo: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {

                        Console.Write(mat[i, j] + ", ");
                        som++;
                    }
                }

            }

            Console.WriteLine();
            Console.Write("Numero(s) Positivo: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] > 0)
                    {

                        Console.Write(mat[i, j] + ", ");
                        som1++;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("Foram encontrados " + som + " número(s) negativo.");
            Console.WriteLine("Foram encontrados " + som1 + " número(s) Positivo.");
            Console.WriteLine(DateTime.Now);
        }
    }
}
