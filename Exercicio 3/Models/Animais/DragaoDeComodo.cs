using Exercicio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models.Animais
{
    public class DragaoDeComodo : Reptil, IOviparo
    {
        public DragaoDeComodo(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, bool escamas, bool casco) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento, escamas, casco)
        {
            nome = "Dragão de Comodo";
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
                Console.WriteLine($"A fêmea do dragão está chocando seus ovos!");
            }
            else
            {
                Console.WriteLine($"O macho {this.Nome} não choca seus ovos");
            }
        }
    }
}
