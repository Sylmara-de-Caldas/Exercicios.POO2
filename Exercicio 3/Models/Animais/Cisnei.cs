using Exercicio_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models.Animais
{
    public class Cisnei : Ave, IVoar, IOviparo
    {
        public int AltitudeMaximaEmMetros { get ; set ; }
        public double VelocidadeDoVoo { get; set; }
    

        public Cisnei(string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento, bool rapina, string corPena) : base(nome, dataNasc, sexo, idade, carnivoro, peconhento, rapina, corPena)
        {
            nome = "Cisnei";
        }

       
        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
