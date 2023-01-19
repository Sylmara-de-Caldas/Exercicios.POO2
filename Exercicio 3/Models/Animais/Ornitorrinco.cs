using Exercicio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models.Animais
{
    public class Ornitorrinco : Mamifero, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get ; set; }
        public bool Mergulo { get; set; }
        public bool AguaDoce { get; set; }
        public Ornitorrinco(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, int qtdMamas, bool pelos, string corPelo) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento, qtdMamas, pelos, corPelo)
        {
            nome = "Ornitorrinco";
        }


        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }
    }
}
