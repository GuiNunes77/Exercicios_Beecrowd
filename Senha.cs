// See https://aka.ms/new-console-template for more information
using System;

class Senha
{
    static void Main(string[] args)
    {
        int senha = 0;

        do
        {
            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            if (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
            }
        } while (senha != 2002);

        Console.WriteLine("Acesso Permitido");
    }
}