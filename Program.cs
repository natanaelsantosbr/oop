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

            var pagamento = new Pagamento();
            pagamento.ToString();

            Console.WriteLine("Hello World!");

        }

        /*
            Encapsulamento
            Agrupar o que faz sentido esta junto           


            Abstração
            Esconde os detalhes, esconde tudo aquilo que não precisa saber     
            Interuptor de energia, Concessionaria
            Expor apenas o necessário

            Herança
            Capacidade de um objeto herdar uma propriedade, metodo e evento de outro objeto.

            Polimorfismo
            Pode ter n forma (metodo) virtual
            Permiti que o metodo seja sobrescrito
            virtual no pai
            override no filho

            

        */

        /*
        private = fica restrito a classe  
        protected = escopo da classe + classe filha (heranca)
        internal = fica disponivel no mesmo namespace
        public = fica visivel para um todo
        */
        public class Pagamento
        {
            /*
            prop
            propfull
            propg
            */

            private DateTime _dataPagamento;
            public DateTime DataPagamento
            {
                /*

                */
                get { return _dataPagamento; }
                set { _dataPagamento = value; }
            }

            /*
            
            */

            public DateTime Vencimento;

            public Address BillingAddress { get; set; }

            //Metodos (Funções que o metodo tem) Polimorfismo (Pai)
            public virtual void Pagar() { }

            //Por padrão toda carga herda do System
            public override string ToString()
            {
                return Vencimento.ToLongDateString();
            }
        }

        public class Address
        {
            public string ZipCode { get; set; }

        }
        class PagamentoBoleto : Pagamento
        {
            public string NumeroBoleto;

            //Polimorfismo Filho
            public override void Pagar()
            {
                //Regra do Boleto
            }
        }

        class PagamentoCartaoDeCredito : Pagamento
        {
            public string Numero;

            //Polimorfismo
            public override void Pagar()
            {
                //Abstração
                this.VerificarAlgumaCoisaApenasDessaClasse();

                //Regra do Cartao do Credito

            }

            //Abstração
            private bool VerificarAlgumaCoisaApenasDessaClasse()
            {
                return true;
            }
        }

        //Nao tem heranca Multipla
        /*class PagamentoCartaoDeCredito : Pagamento, PagamentoBoleto
        {
            public string Numero;
        }*/
    }
}
