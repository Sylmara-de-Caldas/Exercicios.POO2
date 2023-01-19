using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.Models
{
    public abstract class Animal
    {
        public string  Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }
        public Animal (string nome, DateTime dataNasc, char sexo, int idade, bool carnivoro, bool peconhento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
            this.Sexo = sexo;
            this.Idade = idade;
            this.Carnivoro = carnivoro;
            this.Peconhento = peconhento;
        }

        public abstract void Movimentar(string movimento);

        public void Comunicar(string comunicacao)
        {
            Console.WriteLine($" O animal {this.Nome} está {comunicacao}");

        }

        public void Alimentar(string alimento)
        {
            Console.WriteLine($"O animal {this.Nome} está se alimento de {alimento}");
        }

        public virtual void SetInfos()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Data de Nascimento: {this.DataNascimento}");
            Console.WriteLine($"Sexo: {this.Sexo}");
            Console.WriteLine($"Idade: {this.Idade}");
            Console.WriteLine($"Carnivoro: {this.Carnivoro}");
            Console.WriteLine($"Peconhento: {this.Peconhento}");
        }


    }
}
