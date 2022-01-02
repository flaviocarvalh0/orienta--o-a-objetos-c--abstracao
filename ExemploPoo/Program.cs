using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.Write("Informe um nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Informe a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            p1.Apresentar();
            p1.podeDirigir();
        }
    }
}
