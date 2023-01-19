using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public virtual void Cumprimentar()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome}. Prazer em te conhecer!");
        }

        public void DizerIdade()
        {
            Console.WriteLine($"Eu tenho {Idade} anos!");
        }
    }
}
