using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public abstract class Smartphone
    {
        public string NumeroTel {get; private set;}
        public string Modelo { get; protected set; }
        protected string Imei { get; private set; }
        protected int Memoria { get; private set; }

        public Smartphone(string numeroTel, string modelo, string imei, int memoria)
        {
            NumeroTel = numeroTel;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public void Ligar()
        {
            Console.Write("\nDisque o número: ");
            Console.ReadLine();
            Console.WriteLine("Ligando...\n");

        }
        public void ReceberLigacao()
        {
            Console.Beep();
            Console.Beep();
            Console.WriteLine("\nLigação Recebida!\n");
            Console.WriteLine("[1]Atender\n[2]Desligar");
            string chamada = Console.ReadLine();
            switch(chamada) 
            {
                case "1":
                    Console.WriteLine("Chamada atendida... Fale\n");
                    break;
                case "2":
                    Console.WriteLine("Chamada recusada...\n");
                    break;
            }

        }

        public virtual void InstalarAplicativo(string nome)
        {
            Console.WriteLine("\nBuscando aplicativo...");
            Console.WriteLine($"App {nome} encontrado!\n[1]Baixar\n[2]Reinstalar");
            string app = Console.ReadLine();
            switch (app)
            {
                case "1":
                    Console.WriteLine("Baixado com sucesso!\n");
                    break;
                case "2":
                    Console.WriteLine("Reinstalado com sucesso!\n");
                    break;
            }

        }
        public abstract void Inicializar();

        public string Menu()
        {
                Console.WriteLine($"Escolha o que deseja fazer:\n ");
                Console.WriteLine("[1] - Ligação");
                Console.WriteLine("[2] - Receber Ligação");
                Console.WriteLine("[3] - Instalar Aplicativos");
                Console.WriteLine("[4] - Sobre");
                Console.WriteLine("[5] - Desligar");
                string escolha = Console.ReadLine();

                return escolha;

        }

        public void Operacoes(string escolha)
        {
            
                switch (escolha)
                {
                    case "1":
                        Ligar();
                        break;
                    case "2":
                        ReceberLigacao();
                        break;
                    case "3":
                        Console.Write("Pesquisar: \n");
                        string nomeapp = Console.ReadLine();
                        InstalarAplicativo(nomeapp);
                        break;
                    case "4":
                        Console.WriteLine($"\nNúmero Celular: {NumeroTel}");
                        Console.WriteLine($"Modelo: {Modelo}");
                        Console.WriteLine($"IMEI: {Imei}");
                        Console.WriteLine($"Memória: {Memoria}GB\n");
                        break;
                }
           
        }
    }
}
