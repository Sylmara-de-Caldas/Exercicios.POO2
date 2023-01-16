namespace Exercicio_1
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            // 1. instânciando pessoa
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine(); 
            bool check;
            int idade;

            do
            {
                Console.WriteLine("Digite sua idade: ");
                check = int.TryParse(Console.ReadLine(), out idade);
            } while (!check);
            pessoa.Idade = idade;

            pessoa.Cumprimentar();
            pessoa.DizerIdade();

            // 2. instânciando aluno
            Aluno aluno = new Aluno();

            aluno.Nome = "Sylmara";
            aluno.Idade = 21;

            aluno.Cumprimentar();
            aluno.DizerIdade();
            aluno.IrParaEscola();


            // 3. instânciando professor
            Professor professor = new Professor();

            professor.Nome = "Michael";
            professor.Idade = 30;

            professor.Cumprimentar();
            professor.DizerIdade();
            professor.Explicar("Abstração");



        }
    }
}