using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = Opcao();
            while (opcao != "5")
            {

                switch (opcao)
                {
                    case "1":
                        retangulo r = new retangulo();
                        Console.Write("Digite um número: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Digite um outro: ");
                        double b = double.Parse(Console.ReadLine());
                        r.DefinirMedidas(a, b);
                        System.Console.WriteLine($"Área: {r.ObterArea()}");
                        break;
                    case "2":
                        Pessoa p1 = new Pessoa();
                        Console.Write("Informe um nome: ");
                        p1.Nome = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Informe a idade: ");
                        p1.Idade = int.Parse(Console.ReadLine());
                        p1.Apresentar();
                        p1.podeDirigir();
                        break;
                    case "3":
                        
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcao = Opcao();

            }









        }
        private static string Opcao()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Encapsulamento");
            Console.WriteLine("2 - abstração");
            Console.WriteLine("5 - sair");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }
    }
}
