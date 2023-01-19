using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public class Mamifero : Animal
    {
        public int QtdMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorPelo { get; set; }

        public Mamifero(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, int qtdMamas, bool pelos, string corPelo) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento)
        {
            QtdMamas = qtdMamas;
            Pelos = pelos;
            CorPelo = corPelo;

        }


        public void Amamentar()
        {
            if (Sexo == 'F')
            {
                Console.WriteLine($"\nO mamifero {this.Nome} está amamentando seu filhote\n");
            }
        }

        public override void Movimentar(string movimento)
        {
            Console.WriteLine($"O mamifero {this.Nome} está {movimento}!");
        }

        public override void SetInfos()
        {
            base.SetInfos();
            Console.WriteLine($"Quantidade de Mamas: {this.QtdMamas}");
            Console.WriteLine($"Tem Pelos: {this.Pelos}");
            Console.WriteLine($"Cor do Pelo: {this.Pelos}");
        }
    }
}
