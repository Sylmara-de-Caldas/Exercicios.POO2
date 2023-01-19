using Exercicio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models.Animais
{
    public class Lontra : Mamifero, IAquatico
    {

        public bool ViveEmTerra { get; set; }
        public bool Mergulo { get; set; }
        public bool AguaDoce { get; set; }
        public Lontra(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, int qtdMamas, bool pelos, string corPelo) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento, qtdMamas, pelos, corPelo)
        {
            nome = "Lontra";
        }

    }
}
