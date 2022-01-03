using System;
namespace ExemploPoo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public virtual void  Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }

        public void podeDirigir()
        {
            if(Idade > 18)
            {
                Console.WriteLine($"{Nome}, você já pode tirar a carteira de habilitação");
            }else{
                Console.WriteLine($"Carteira de habilitação disponivel apos os 18 ano");
            }
        }
    }
}