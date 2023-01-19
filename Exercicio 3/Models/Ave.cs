using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public class Ave : Animal
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }

        public Ave(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, bool rapina, string corPena) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento)
        {
            this.Rapina = rapina;
            this.CorPena = corPena;
        }
        public void Ciscar()
        {
            Console.WriteLine($"A ave {this.Nome} está ciscando!");
        }

        public override void Movimentar(string movimento)
        {
            Console.WriteLine($"A ave {this.Nome} está {movimento}!");
        }

        public override void SetInfos()
        {
            base.SetInfos();
            Console.WriteLine($"Rapina: {this.Rapina}");
            Console.WriteLine($"Cor da Pena: {this.CorPena}");

        }
    }
}
