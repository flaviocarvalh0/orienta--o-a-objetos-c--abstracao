using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = Opcao();
            while (opcao.ToUpper() != "X")
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

                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }


                        break;

                    case "4":
                        calculadora calc = new calculadora();
                        System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(1, 3));
                        System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(1, 3, 7));
                        break;

                    case "5":

                        string op = OpcaoAbstrata();

                        while (op.ToUpper() != "X")
                        {
                            switch (op)
                            {
                                case "1":
                                    Corrente c = new Corrente();
                                    double valor;
                                    System.Console.Write("Digite o valor que deseja depositar: ");
                                    valor = double.Parse(Console.ReadLine());
                                    System.Console.WriteLine();

                                    if (valor < 0)
                                    {
                                        System.Console.WriteLine("Valor inválido");
                                    }
                                    else if (valor > 1500)
                                    {
                                        System.Console.WriteLine("Limite diário por depósito de 1500R$");
                                    }
                                    else
                                    {
                                        c.Creditar(valor);
                                        c.ExibirSaldo();
                                    }
                                    break;

                                case "2":
                                    System.Console.WriteLine("Uma classe selada tem como objetivo de impedir que outras classes façam uma herança dela, ou seja, nenhuma classe pode ser sua derivada Também existem métodos e propriedades seladas");

                                    break;
                                case "3":

                                    System.Console.WriteLine("A classe System.Object é a mãe de todas as classes na hierarquia do .NET Todas as classes derivam, direta ou indiretamente da classe Object, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas.");
                                    Computador comp = new Computador();
                                    //System.Console.WriteLine(comp.ToString());
                                    break;

                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
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
            Console.WriteLine("3 - Herança e Polimorfismo");
            Console.WriteLine("4 - Polimorfismo em tempo de compilação");
            Console.WriteLine("5 - Clase abstrata");
            Console.WriteLine("X - sair");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }

        private static string OpcaoAbstrata()
        {
            Console.WriteLine();
            Console.WriteLine("1 - classe abstrata");
            Console.WriteLine("2 - métodos selados");
            Console.WriteLine("3 - classe object");
            Console.WriteLine("X - sair");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }
    }
}
