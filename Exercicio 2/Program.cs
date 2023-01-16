using System.Xml;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caso queira instanciar o modelo IPHONE
            Iphone iphone = new Iphone("91234-5678", "SE", "A123B456C789D", 128);
       
            iphone.Inicializar();
            string escolhaIphone;
            do
            {
                escolhaIphone = iphone.Menu();
                iphone.Operacoes(escolhaIphone);

            } while (escolhaIphone != "5");


            //Caso queira instanciar o modelo MOTOROLA
            Motorola motorola = new Motorola("99123-4567", "G15", "E123F456G789H", 64);
            motorola.Inicializar();
            string escolhaMotorola;
            do
            {
                escolhaMotorola = motorola.Menu();
                iphone.Operacoes(escolhaMotorola);

            } while (escolhaMotorola != "5");
        }
    }
}