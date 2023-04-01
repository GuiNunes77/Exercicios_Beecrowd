using System;

class Program
{
    static void Main(string[] args)
    {
        double[] valores = new double[6];
        int qtdPositivos = 0;
        double somaPositivos = 0;

        for (int i = 0; i < 6; i++)
        {
            valores[i] = double.Parse(Console.ReadLine());
            if (valores[i] > 0)
            {
                qtdPositivos++;
                somaPositivos += valores[i];
            }
        }

        Console.WriteLine(qtdPositivos + " valores positivos");
        Console.WriteLine((somaPositivos / qtdPositivos).ToString("F1"));
    }
}




