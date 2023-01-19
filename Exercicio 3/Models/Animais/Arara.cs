using Exercicio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models.Animais
{
    public class Arara : Ave, IVoar, IOviparo

    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Arara(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, bool rapina, string corPena , int altMax, double velVoo) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento, rapina, corPena)
        {
            this.AltitudeMaximaEmMetros = altMax;
            this.VelocidadeDoVoo = velVoo;
        
        }


        public void Voar()
        {
            Console.WriteLine($"A arara {CorPena} está voando!");
        }

        public void Botar()
        {
            Console.WriteLine($"A arara {CorPena} está botando seus ovos!");
        }

        public void Chocar()
        {
            Console.WriteLine($"A arara {CorPena} está chocando seus ovos!");
        }
    }
}
