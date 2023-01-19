using Exercicio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models.Animais
{
    public class Jacare : Reptil, IAquatico, IOviparo
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulo { get; set; }
        public bool AguaDoce { get; set; }

        public Jacare(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, bool escamas, bool casco) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento, escamas, casco)
        {
            nome = "Jacaré";
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
