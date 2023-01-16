using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public class Iphone: Smartphone
    {
        public Iphone(string numeroTel, string modelo, string imei, int memoria) : base(numeroTel, modelo, imei, memoria)
        {
            this.Modelo = "IPHONE " + modelo;
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Bem vindo à App Store!");
            base.InstalarAplicativo(nome);
        }

        public override void Inicializar()
        {
            Console.WriteLine("Bem vindo ao IOS!\n");
           
        }
    }
}
