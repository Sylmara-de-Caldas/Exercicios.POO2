using Exercicio_4.Models;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio_4
{
    public class Program
    {
        /*
      1.Em seguida, na classe Program, crie um método chamado DisplayPublicProperties que, usando Reflection, exiba todas as 
        Propriedades Públicas da classe Student. No método Main da classe Program, coloque uma chamada para o método DisplayPublicProperties.
        
      2.Agora, adicione na classe Program um outro método chamado CreateInstance que
       2.1 Use Reflection para criar uma instância (objeto) da classe Student e, em seguida;
       2.2 Use Reflection para preencher as propriedades públicas do objeto. Não é necessário se preocupar com a adição de novas 
        propriedades, isto é, sempre serão preenchidos apenas o Name, University e RollNumber.
        
      3.Use Reflection para chamar o método DisplayInfo do objeto criado no item 2.1.
       3.1 Ao final do exercício, coloque o seu código em um repositório público no GitHub e submeta o link para avaliação
         */
       
        static void Main(string[] args)
        {
            Student sylmara = new Student();
            Console.WriteLine("Mostrando propriedades: ");
            DisplayPublicProperties(sylmara);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Aluno instanciado: ");
            CreateInstance();


            static void DisplayPublicProperties(object objeto)
            {
                Type tipo = objeto.GetType();
                var properties = tipo.GetProperties();
                foreach(PropertyInfo propriedade in properties)
                {
                    Console.WriteLine(propriedade.Name);
                }

    }
           static void CreateInstance()
           {
                Type tipo = typeof(Student);
                object objeto = Activator.CreateInstance(tipo);
                PropertyInfo nomeProp = tipo.GetProperty("Name");
                nomeProp.SetValue(objeto, "Sylmara");
                PropertyInfo universidadeProp = tipo.GetProperty("University");
                universidadeProp.SetValue(objeto, "ADA - LET'S CODE");
                PropertyInfo idProp = tipo.GetProperty("RollNumber");
                idProp.SetValue(objeto, 010203);
                MethodInfo displayMetodo = tipo.GetMethod("DisplayInfo");
                displayMetodo.Invoke(objeto, null);

            }
        }
    }
}