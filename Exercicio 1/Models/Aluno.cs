using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Models
{
    public class Aluno : Pessoa
    {

        public override void Cumprimentar()
        {
            Console.WriteLine($"\nOie, sou aluno(a) {Nome}");
        }
        public void IrParaEscola()
        {
            Console.WriteLine("Estou indo para escola\n");
        }
    }
}
