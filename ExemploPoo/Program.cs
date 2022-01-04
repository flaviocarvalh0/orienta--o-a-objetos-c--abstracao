using System;
using System.Collections.Generic;
using System.IO;
using ExemploPoo.helper;
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
                        System.Console.WriteLine("Resultado da segunda Subtração: " + calc.Subtrair(5, 3));
                        System.Console.WriteLine("Resultado da segunda Divisão: " + calc.Dividir(20, 10));
                        System.Console.WriteLine("Resultado da segunda Multiplicação: " + calc.Multiplicar(10, 3));

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
                            break;
                        }

                        break;



                    case "6":

                        string op2 = opcaoDiretorios();
                        var caminho = @"C:\Users\flavi\Desktop\Nova pasta\manipulando arquivos";
                        FilerHelper helper = new FilerHelper();
                        while (op2.ToUpper() != "X")
                        {
                            switch (op2)
                            {
                                case "1":
                                    helper.ListarDiretorios(caminho);
                                    break;

                                case "2":
                                    helper.ListarArquivosDiretorios(caminho);
                                    System.Console.WriteLine();
                                    break;

                                case "3":
                                    System.Console.Write("informe um nome para o diretorio: ");
                                    var diretorio = Console.ReadLine();
                                    var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", diretorio);
                                    System.Console.WriteLine("Criando diretorio" + caminhoPathCombine);
                                    helper.CriarDiretorio(caminhoPathCombine);
                                    break;

                                case "4":
                                    System.Console.WriteLine("Informe o nome exato da pasta que deseja apagar");
                                    var delete = Console.ReadLine();
                                    var caminhoPathdelete = Path.Combine(caminho, delete);
                                    helper.ApagarDiretorio(caminhoPathdelete, true);
                                    break;

                                case "5":
                                    Console.Write("Informe o nome do arquivo com .txt: ");
                                    var txt = Console.ReadLine();
                                    Console.Write("Informe o conteudo do texto: ");
                                    var conteudo = Console.ReadLine();
                                    var caminhoArquivo = Path.Combine(caminho, txt);
                                    helper.CriarArquivoTexto(caminhoArquivo, conteudo);
                                    break;

                                case "6":
                                    Console.Write("Informe o nome do arquivo com .txt: ");
                                    var txtLista = Console.ReadLine();
                                    Console.Write("Informe o conteudo do texto: ");
                                    var l1 = Console.ReadLine();
                                    Console.Write("Informe o conteudo do texto: ");
                                    var l2 = Console.ReadLine();
                                    Console.Write("Informe o conteudo do texto: ");
                                    var l3 = Console.ReadLine();
                                    var listaString = new List<string> { l1, l2, l3 };
                                    var caminhoArquivoLista = Path.Combine(caminho, txtLista);
                                    helper.CriarArquivoTextoStream(caminhoArquivoLista, listaString);
                                    Console.WriteLine("Adiconar linhas ao arquivo de stream");
                                    Console.Write("Informe o conteudo o coonteudo a ser adicionado: ");
                                    var l4 = Console.ReadLine();
                                    Console.Write("Informe o conteudo o coonteudo a ser adicionado: ");
                                    var l5 = Console.ReadLine();
                                    Console.Write("Informe o conteudo o coonteudo a ser adicionado: ");
                                    var l6 = Console.ReadLine();
                                    var listaStringContinuacao = new List<string> { l4, l5, l6 };
                                    helper.AdicionarTextoStream(caminhoArquivoLista, listaStringContinuacao);

                                    break;

                                case "7":
                                    Console.Write("Informe o nome do arquivo que deseja ler: ");
                                    var txtLer = Console.ReadLine();
                                    var caminhoArquivoLeitura = Path.Combine(caminho ,txtLer);
                                    helper.LerArquivoStream(caminhoArquivoLeitura);
                                    break;
                                case "8":
                                    Console.WriteLine("Informe o nome do arquivo que deseja mover: ");
                                    var moverArquivo = Console.ReadLine();
                                    Console.WriteLine("Informe o caminho que deseja mover o arquivo: ");
                                    var mover = Console.ReadLine();
                                    var caminhoArquivoMovido = Path.Combine(caminho, moverArquivo);
                                    var NovoCaminhoArquivo = Path.Combine(caminho, mover, moverArquivo);
                                    helper.MoverArquivo(caminhoArquivoMovido, NovoCaminhoArquivo, false);
                                    break;
                                case "9":
                                    Console.Write("Digite o nome do arquivo q deseja copiar: ");
                                    var copy = Console.ReadLine();    
                                    Console.Write("Digite o nome da cópia: ");
                                    var bkp = Console.ReadLine();
                                    var CaminhoArquivoTeste = Path.Combine(caminho,copy);
                                    var CaminhoArquivoTesteCopia = Path.Combine(caminho,bkp);
                                    helper.CopiarArquivo(CaminhoArquivoTeste, CaminhoArquivoTesteCopia, false);
                                    break;

                                    case "10":
                                    Console.Write("Informe o nome do arquivo que deseja deletar: ");
                                    var del = Console.ReadLine();
                                    var CaminhoArquivoDeletado = Path.Combine(caminho, del);
                                    helper.DeletarArquivo(CaminhoArquivoDeletado);
                                    break;
                            }
                            break;
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
            Console.WriteLine("4 - Polimorfismo em tempo de compilação e Interface");
            Console.WriteLine("5 - Clase abstrata");
            Console.WriteLine("6 - Diretorios");
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

        private static string opcaoDiretorios()
        {
            Console.WriteLine();
            Console.WriteLine("1 - listar diretorios");
            Console.WriteLine("2 - listar arquivos");
            Console.WriteLine("3 - criar diretorio");
            Console.WriteLine("4 - apagar diretorio");
            Console.WriteLine("5 - criar arquivo");
            Console.WriteLine("6 - criar arquivo em stream");
            Console.WriteLine("7 - ler um arquivo");
            Console.WriteLine("8 - mover um arquivo");
            Console.WriteLine("9 - copiar um arquivo");
            Console.WriteLine("10 - deletar um arquivo");
            Console.WriteLine("X - sair");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
