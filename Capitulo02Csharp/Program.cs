using System;

namespace Capitulo02Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void ExemploUsoDeExpressao(int numero)
        {
            bool numeroPar = numero % 2 == 0;
            int resultado = numeroPar ? 2 : 0;
            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        static void ExemploUsoDeDeclaracao(int numero)
        {
            int resultado = 0;
            bool numeroPar = numero % 2 == 0;

            if (numeroPar)
            {
                resultado = 2;
            }

            Console.WriteLine(resultado);

            Console.ReadKey();
        }

        static void ExemploComTempoMutavel()
        {
            var periodo = new PeriodoDeTempo();

            periodo.DataInicial = DateTime.Parse("20/08/2019");
            periodo.DataFinal = DateTime.Parse("31/08/2019");

            DateTime[] datasParaTeste = new DateTime[]
            {
                DateTime.Parse("18/08/2019"),
                DateTime.Parse("22/08/2019"),
                DateTime.Parse("01/09/2019")
            };

            foreach (DateTime data in datasParaTeste)
            {
                bool resultadoDaVerificacao = periodo.VerificarSeDataEstaEntreOPeriodo(data);

                Console.WriteLine(resultadoDaVerificacao);
            }

            //periodo.DataFinal = DateTime.MaxValue;

            //Console.WriteLine("Resultado após a alteração: ");

            //foreach (DateTime data in datasParaTeste)
            //{
            //    bool resultadoDaVerificacao = periodo.VerificarSeDataEstaEntreOPeriodo(data);

            //    Console.WriteLine(resultadoDaVerificacao);
            //}

            periodo.AdicionaDias(30);

            Console.WriteLine("Resultado após a alteração: ");

            foreach (DateTime data in datasParaTeste)
            {
                bool resultadoDaVerificacao = periodo.VerificarSeDataEstaEntreOPeriodo(data);

                Console.WriteLine(resultadoDaVerificacao);
            }

            Console.ReadKey();

        }
    }
}
