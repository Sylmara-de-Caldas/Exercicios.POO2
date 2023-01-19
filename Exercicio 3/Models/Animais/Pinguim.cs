using Exercicio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models.Animais
{
    public class Pinguim : Ave, IVoar, IOviparo
    {

        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public Pinguim(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, bool rapina, string corPena) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento, rapina, corPena)
        {
            nome = "Pinguim";
        }

        public void Botar()
        {
            if (this.Sexo == 'f')
            {
                Console.WriteLine($"A fêmea está botando seus ovos!");
            }
            else
            {
                Console.WriteLine("O macho não bota ovos");
            }
        }

        public void Chocar()
        {
            if (this.Sexo == 'f')
            {
                Console.WriteLine($"A fêmea não choca seus ovos!");
            }
            else
            {
                Console.WriteLine("O macho está incubando seu filhote dentro do ovo");
            }
        }

        public void Voar()
        {
            Console.WriteLine("Pinguim não voa!");
        }
    }
}
