using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public class Reptil : Animal
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }
        public Reptil(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, bool escamas, bool casco) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento)
        {
            this.TemEscamas = escamas;
            this.TemCasco = casco;
        }

    

        public override void Movimentar(string movimento)
        {
            Console.WriteLine($"O réptil {this.Nome} está {movimento}");
        }
        public override void SetInfos()
        {
            base.SetInfos();
            Console.WriteLine($"Escamas: {this.TemEscamas}");
            Console.WriteLine($"Casco: {this.TemCasco}");
        }

    }
}
