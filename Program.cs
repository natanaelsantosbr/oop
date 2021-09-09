using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Diferença entre classe e structs ?

            E a forma que é armazenado.

            Uma classe tem propriedade, metodos, eventos e é um tipo de refencia. Armazena apenas o endereço e não o dado.

            structs é um tipo de valor. Armazenada os dados em si.

            Class um molde para um objeto.

            Vantagens de OOP
            - Pegar um projeto grande e dividi em pequenas partes
            */


            Console.WriteLine("Hello World!");
        }

        /*
            Encapsulamento
            Agrupar o que faz sentido esta junto                        
        */
        class Pagamento
        {
            //Propriedades  (Caractereisticas que o metodo tem)
            DateTime Vencimento;

            //Metodos (Funções que o metodo tem)
            void Pagar(){}            

        }
    }
}
