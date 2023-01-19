using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models.Animais
{
    public class Chacal : Mamifero
    {
        public Chacal(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, int qtdMamas, bool pelos, string corPelo) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento, qtdMamas, pelos, corPelo)
        {
            nome = "Chacal";
        }
    }
}
