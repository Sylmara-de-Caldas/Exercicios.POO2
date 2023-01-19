using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Interfaces
{
    internal interface IVoar
    {
        int AltitudeMaximaEmMetros { get; set; }
        double VelocidadeDoVoo { get; set; }

        public void Voar();
    }
}
