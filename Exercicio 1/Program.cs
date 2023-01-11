namespace Exercicio_1
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            // 1. instânciando pessoa
            Pessoa pessoa = new Pessoa();

            // coletando os dados
            Console.WriteLine("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine(); 
            bool check;
            int idade;

            //verificando a entrada
            do
            {
                Console.WriteLine("Digite sua idade: ");
                check = int.TryParse(Console.ReadLine(), out idade);
            } while (!check);
            pessoa.Idade = idade;

            // chamando os métodos
            pessoa.Cumprimentar();
            pessoa.DizerIdade();

            // 2. instânciando aluno
            Aluno aluno = new Aluno();

            // inserindo dados
            aluno.Nome = "Sylmara";
            aluno.Idade = 21;

            // chamando os métodos
            aluno.Cumprimentar();
            aluno.DizerIdade();
            aluno.IrParaEscola();


            // 3. instânciando professor
            Professor professor = new Professor();

            // inserindo dados
            professor.Nome = "Michael";
            professor.Idade = 30;

            // chamando os métodos 
            professor.Cumprimentar();
            professor.DizerIdade();
            professor.Explicar("Abstração");



        }
    }
}