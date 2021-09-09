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

            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.NumeroBoleto = "123";

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

            3. Herança
            Capacidade de um objeto herdar uma propriedade, metodo e evento de outro objeto.

        */
        class Pagamento
        {
            //Propriedades  (Caractereisticas que o metodo tem)
            public DateTime Vencimento;

            //Metodos (Funções que o metodo tem)
            public void Pagar() { }
        }

        class PagamentoBoleto : Pagamento
        {
            public string NumeroBoleto;
        }

        class PagamentoCartaoDeCredito : Pagamento
        {
            public string Numero;
        }

        //Nao tem heranca Multipla
        /*class PagamentoCartaoDeCredito : Pagamento, PagamentoBoleto
        {
            public string Numero;
        }*/
    }
}
