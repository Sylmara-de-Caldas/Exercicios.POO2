
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dicionario dicionario = new Dicionario();

            Console.WriteLine("Bem vindo!!");
            Console.WriteLine("Dicionário -  Let’s Speak!");

            Console.WriteLine("\nO que deseja fazer?");
            Console.WriteLine("\n[1] - Consultar termo");
            Console.WriteLine("[2] - Adicionar termo");
            Console.WriteLine("[3] - Sair\n");
            string input = Console.ReadLine();

            do
            {
                switch (input)
                {
                    case "1":
                        dicionario.VerificarTermo(dicionario);
                        break;
                    case "2":
                        dicionario.AdicionarTermo();
                        break;
                }
            } while (input != "3");
           





        }


    }
}