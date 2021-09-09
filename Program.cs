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
            1. Paradigma
            Encapsulamento
            Agrupar o que faz sentido esta junto           


            2. Paradigma        
            Abstração
            Esconde os detalhes, esconde tudo aquilo que não precisa saber     
            Interuptor de energia, Concessionaria
            Expor apenas o necessário
        */
        class Pagamento
        {
            //Propriedades  (Caractereisticas que o metodo tem)
            DateTime Vencimento;

            //Metodos (Funções que o metodo tem)
            void Pagar()
            {
                this.ConsultarSaldoDoCartao();
            }            


            //Abstraido. Acontece apenas na classe de Pagamento. Nenhuma outra classe precisa saber desse detalhe
            private void ConsultarSaldoDoCartao(){

            }
                    }
    }
}
