using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Dicionario
    {
        public string Termo { get; set; }
        public string Traducao { get; set; }

        public Dictionary<string, string> DicionarPadrao()
        {
            Dictionary<string, string> dicionario = new();

            dicionario["Get up"] = "levantar; acordar";
            dicionario["Give up"] = "desistir";
            dicionario["Give out"] = "distribuir; chegar ao fim; parar de funcionar";
            dicionario["Go after"] = "ir atrás, perseguir";
            dicionario["Look into"] = "investigar, examinar, analisar";
            dicionario["Make up"] = "inventar, criar (história, explicação); maquiar; fazer as pazes";
            dicionario["Take apart"] = "desmontar";
            dicionario["Take over"] = "assumir o controle (de algo)";
            dicionario["Turn down"] = "trejeitar, recusar; abaixar";
            dicionario["Get out of hand "] = "perder o controle";
            dicionario["Miss the boat"] = "ser tarde demais";

            return dicionario;
        }
        public void VerificarTermo(Dictionary<string, string> dicionario)
        {
            Console.WriteLine("Digite o termo que deseja verificar: ");

            string termo = Console.ReadLine();

            string[] termos = termo.Split(" ");

            bool check;

            string resposta = string.Empty;

            foreach (string term in termos)
            {
                check = dicionario.TryGetValue(term, out string traducao);

            }

            Console.WriteLine($"O significado do termo {termo} é: {resposta.Trim()}.");

        }
        public void AdicionarTermo()
        {
            Console.WriteLine("Digite quantos termos deseja adicionar: ");
            int qtde = int.Parse(Console.ReadLine());

            Dicionario[] vetor = new Dicionario[qtde];

            for (int i = 0; i < qtde; i++)
            {
                string termo = Console.ReadLine();
                string traducao = Console.ReadLine();
                vetor[i] = new Dicionario { Termo = termo, Traducao = traducao };
                Console.Write("Adição concluída: ");
                Console.WriteLine($"'{termo}' = '{traducao}' ");
            }

        }
    }
}
