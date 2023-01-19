using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2.Models
{
    public class Motorola : Smartphone
    {
        public Motorola(string numeroTel, string modelo, string imei, int memoria) : base(numeroTel, modelo, imei, memoria)
        {
            Modelo = "MOTOROLA " + modelo;

        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Bem vindo ao Google Play!");
            base.InstalarAplicativo(nome);
        }

        public override void Inicializar()
        {
            Console.WriteLine("Bem vindo ao ANDROID!\n");

        }
    }
}
