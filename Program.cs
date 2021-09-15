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

            var pagamentoBoleto = new PagamentoBoleto(DateTime.Now);
            pagamentoBoleto.NumeroBoleto = "123";

            /*Dispose*/
            // var pagamento = new Pagamento();
            // pagamento.ToString();
            // pagamento.Dispose();

            using (var pagamento2 = new Pagamento())
            {
                System.Console.WriteLine("Processando pagamento");
            }

            /*Partial Class*/
            var payment = new Payment();
            payment.PropriedadeA = 1;
            payment.PropriedadeB = 2;


            // //Upcast (Filho para o Pai)
            // var pessoa = new Pessoa();
            // pessoa = new PessoaFisica();
            // pessoa = new PessoaJuridica();

            // //DownCast
            // var pessoaFisica = new PessoaFisica();
            // var pessoaJuridica = new PessoaJuridica();


            // pessoaFisica = (PessoaFisica)pessoa;

            var pessoaA = new Pessoa(1, "Natanael");
            var pessoaB = new Pessoa(1, "Natanael");

            /*
            Pq é diferente ? Pq eh um tipo de referencia, não guarda os dados
            */
            System.Console.WriteLine(pessoaA == pessoaB);
            System.Console.WriteLine(pessoaA.Equals(pessoaB));


            //Delegates => Metodos Anonimos             / Estou delegando essa função
            //Tem quer ter a mesma assinatura
            //Uma função que chama outra função
            //Delegar pra qualquer outra classe
            var pag = new Pagar.Paga(RealizarPagamento);
            pag(25);


            var sala = new Sala(3);
            sala.EventoQueASalaEstaLotadaEvent += OnQuandoAMinhaSalaEncher;
            sala.ReservarAssento();
            sala.ReservarAssento();
            sala.ReservarAssento();
            sala.ReservarAssento();
            sala.ReservarAssento();
            sala.ReservarAssento();
            sala.ReservarAssento();


            var person = new Pessoas();
            var pagamentoo = new Pagamentoo();
            var assinatura = new Assinaturaa();
            var context = new DataContext<IPessoa, Pagamentoo, Assinaturaa>();
            context.Save(person);
            context.Save(pagamentoo);
            context.Save(assinatura);

        }


        /*Uma classe generica. O que isso signifca ?
                    Que eu posso salvar uma pessoa, pagamento, assinatura*/
        public class DataContext<P, PA, A>
        where P : IPessoa
        where PA : Pagamentoo
        where A : Assinaturaa
        {

            public void Save(P entidade)
            {

            }

            public void Save(PA entidade)
            {

            }

            public void Save(A entidade)
            {

            }
        }

        public interface IPessoa { }

        public class Pessoas : IPessoa { }
        public class Pagamentoo { }
        public class Assinaturaa { }


        static void OnQuandoAMinhaSalaEncher(object sender, EventArgs e)
        {
            System.Console.WriteLine("Sala lotada");
        }

        public class Sala
        {
            public Sala(int assentos)
            {
                this.Assentos = assentos;
                this.AssentosEmUso = 0;
            }

            private int AssentosEmUso = 0;
            public int Assentos { get; set; }

            public void ReservarAssento()
            {
                this.AssentosEmUso++;

                if (this.AssentosEmUso >= this.Assentos)
                {
                    OnSalaFicarIndisponivel(EventArgs.Empty);
                }
                else
                {
                    System.Console.WriteLine("Assento reservado");
                }
            }

            //Declarar um evento

            public event EventHandler EventoQueASalaEstaLotadaEvent;

            //Metodo que executa o evento
            protected virtual void OnSalaFicarIndisponivel(EventArgs e)
            {
                EventHandler handler = EventoQueASalaEstaLotadaEvent;
                handler?.Invoke(this, e);
            }

        }


        static void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($"Pago o valor de {valor}");
        }

        public class Pagar
        {
            public delegate void Paga(double valor);
        }


        /*Classe Pai, Raiz*/

        public class Pessoa : IEquatable<Pessoa>
        {

            public Pessoa()
            {

            }

            public Pessoa(int id, string nome)
            {
                this.Id = id;
                this.Nome = nome;
            }
            public int Id { get; set; }
            public string Nome { get; set; }

            /*Comparando objetos*/
            public bool Equals(Pessoa other)
            {
                return this.Id == other.Id;
            }
        }

        /*Classes Filha*/
        public class PessoaFisica : Pessoa
        {
            public string CPF { get; set; }
        }

        public class PessoaJuridica : Pessoa
        {
            public string CNPJ { get; set; }

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
        public class Pagamento : IDisposable
        {

            //Garbage Collector - Coletor de lixo
            /*
            Olha para a memoria e tudo aquilo que não esta sendo utilizado e retirado
            Tudo que for colocado como null eh retirado tbm
            GC.Colletor = Não é legal chamar ele.
            */

            public Pagamento()
            {
                System.Console.WriteLine("Iniciando Pagamento");
            }


            public Pagamento(DateTime vencimento)
            {
                this.Vencimento = vencimento;
            }

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


            /*Sobrescarga de metodo. Assinatura do metodo e parametros diferentes*/
            public void Pagar(string numero) { }
            public void Pagar(string numero, DateTime vencimento) { }

            /*Sobreescrita do metodo (virtual).Reescrita do método */
            public virtual void Pagar() { }

            //Por padrão toda carga herda do System
            public override string ToString()
            {
                return Vencimento.ToLongDateString();
            }

            public void Dispose()
            {
                System.Console.WriteLine("Finalizando projeto");
            }
        }

        public class Address
        {
            public string ZipCode { get; set; }

        }
        class PagamentoBoleto : Pagamento
        {
            public string NumeroBoleto;

            public PagamentoBoleto(DateTime vencimento) : base(vencimento)
            {
            }

            //Polimorfismo Filho
            public override void Pagar()
            {
                base.Pagar();
                //Regra do Boleto
            }
        }

        public class PagamentoCartaoDeCredito : Pagamento
        {
            public string Numero;

            public PagamentoCartaoDeCredito(DateTime vencimento) : base(vencimento)
            {
            }

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

        /*
            Sempre a mesma informação para todos os usuarios
        */
        public static class Settings
        {
            public static string API_URL { get; set; }
        }

        /*
         Classes seladas = Inibi alguem de estender ela, herdar ela
         Garantir apenas uma forma
         Nao pode ter outras versões
         Tirar a herança
        */

        public sealed class PagamentoSelada
        {
            public DateTime Vencimento { get; private set; }
        }

        // public class Pagamento2 : PagamentoSelada
        // {

        // }


        /*
        Contrato = Conjunto de regras que ambas partes devem realizar
        OOP = Interface = Como uma classe deve ser
        Contrato = Como fazer o que precisar fazer
        */

        public interface IPayment
        {
            DateTime Vencimento { get; set; }

            void Pagar(double valor);


            /*C# permiti implementação na interface*/
            void Pagar2()
            {

            }
        }

        /*Essa classe não pode ser instanciada, ela so pode ser herdada*/
        public abstract class Pagament : IPayment
        {
            public DateTime Vencimento { get; set; }

            public virtual void Pagar(double valor)
            {

            }
        }

        public class PagarCartaoDeCredito : Pagament
        {
            public override void Pagar(double valor)
            {
                base.Pagar(valor);
            }
        }

        public class PagarBoleto : Pagament
        {
            public override void Pagar(double valor)
            {
                base.Pagar(valor);
            }
        }

        public class PagarPix : Pagament
        {
            public override void Pagar(double valor)
            {
                base.Pagar(valor);
            }
        }
    }
}
