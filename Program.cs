// See https://aka.ms/new-console-template for more information
using System;

class Program {

    static void Main(string[] args) {
        int score0;
        int n;

        Console.WriteLine("Insira o numero de rodadas: ");
        while ((n = int.Parse(Console.ReadLine())) != 0)
        {
            int[] score = new int[2];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Insira os números: ");
                string[] line = Console.ReadLine().Split();
                int a = int.Parse(line[0]);
                int b = int.Parse(line[1]);
                if (a > b)
                {
                    score[0]++;
                }
                else if (b > a)
                {
                    score[1]++;
                }
            }
            Console.WriteLine($"O placar ficou {score[0]} a {score[1]}");
        }
    }
}

