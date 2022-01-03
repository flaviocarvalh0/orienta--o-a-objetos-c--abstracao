namespace ExemploPoo.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }


        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é {Salario}");
        }
    }
}