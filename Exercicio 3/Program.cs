using Exercicio_3.Models.Animais;

namespace Exercicio_3
{
    internal class Program
    {
        /*Dadas as classes base no diagrama abaixo, criar as classes para os seguintes animais
        : leão, chacal, morcego, cisne, arara, dragão de comodo, lontra, pinguim, coruja, 
        elefante e jacaré. Deve estar adequado também o cadastro de um ornitorrinco.

        Lembre-se de verificar as características de cada animal, por exemplo, um réptil 
        que seja aquático E terrestre, etc.*/
        static void Main(string[] args)
        {
            Arara arara = new Arara("Arara", DateTime.Now, 'f', 01, false, false, false, "Azul", 50, 100);
            DragaoDeComodo dragrao = new DragaoDeComodo("Dragão de Comodo", DateTime.Today, 'm', 01, true, true, false, true);
            Pinguim pinguim = new Pinguim("Pinguim", DateTime.Now, 'm', 01, false, false, false, "Preto e Branco");
            Elefante elefante = new Elefante("Elefante", DateTime.Today, 'f', 01, false, false, 2, true, "Cinza");

            arara.SetInfos();
            Console.WriteLine();
            dragrao.SetInfos();
            Console.WriteLine();
            pinguim.SetInfos();
            Console.WriteLine();
            elefante.SetInfos();
        }
    }
}