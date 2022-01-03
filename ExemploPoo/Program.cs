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
                        Console.Write(" 1 - Para professor\n 2 - Para aluno\n");
                        int escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            Professor prof = new Professor();
                            Console.Write("Informe um nome: ");
                            prof.Nome = Console.ReadLine();
                            Console.Write("Informe a idade: ");
                            prof.Idade = int.Parse(Console.ReadLine());
                            Console.Write("Informe o salario: ");
                            prof.Salario = double.Parse(Console.ReadLine());
                            prof.Apresentar();
                            Console.Write($"e recebo {prof.Salario}");
                        }
                        else if (escolha == 2)
                        {

                            Aluno a1 = new Aluno();
                            Console.Write("Informe um nome: ");
                            a1.Nome = Console.ReadLine();
                            Console.Write("Informe a idade: ");
                            a1.Idade = int.Parse(Console.ReadLine());
                            Console.Write("Informe a nota: ");
                            a1.Nota = int.Parse(Console.ReadLine());
                            a1.Apresentar();
                            Console.Write($"Minha nota foi: {a1.Nota}");
                        }else
                        {
                            Console.WriteLine("Opção inválida!");
                        }


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
            Console.WriteLine("3 - Herança");
            Console.WriteLine("5 - sair");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }
    }
}
