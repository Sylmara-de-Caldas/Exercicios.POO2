using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Models
{
    public class Professor : Pessoa
    {
        public override void Cumprimentar()
        {
            Console.WriteLine($"\nOlá, sou professor(a) {Nome}. Prazer em conhece-los!");
        }
        public void Explicar(string assunto)
        {
            Console.WriteLine($"Na aula de hoje explicarei sobre: {assunto}. Abram os cadernos!");
        }
    }
}
