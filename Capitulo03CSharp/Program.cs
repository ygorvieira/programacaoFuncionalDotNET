using System;
using System.Collections.Generic;
using System.Linq;

namespace Capitulo03CSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<int> numerosPares;
            IEnumerable<int> numeros = Enumerable.Range(0, 10);

            Func<int, bool> metodoParaFiltrar = VerificadorNumeroPar.NumeroEPar;

            numerosPares = numeros.Where(metodoParaFiltrar);
        }

        public static void ExecutarAcaoSobreElementos<TipoElemento> (List<TipoElemento> lista, Action<TipoElemento> acao)
        {
            lista.ForEach(acao);
        }

        public static void ImprimirNomes(List<string> nomes)
        {
            ExecutarAcaoSobreElementos(nomes, Console.WriteLine);
        }

        public static void ImprimirDobroDosNumeros(List<int> numeros)
        {
            ExecutarAcaoSobreElementos(numeros, numero => Console.WriteLine(numero * 2));
        }

        private static void ObterNumerosParesDeUmaLista()
        {
            IEnumerable<int> numerosPares;
            IEnumerable<int> numeros = Enumerable.Range(0, 10);

            numerosPares = numeros.Where(n => n % 2 == 0);
        }

        public void EscreveSeNumeroEParOuImpar(int numero)
        {
            Func<bool> verificaSeONumeroEPar = () => numero % 2 == 0;

            Action escreveNumeroPar = () => Console.WriteLine(string.Format("O número {0} é par", numero));

            Action escreveNumeroImpar = () => Console.WriteLine(string.Format("O número {0} é ímpar", numero));

            if (verificaSeONumeroEPar())
            {
                escreveNumeroPar();
            }
            else
            {
                escreveNumeroImpar();
            }
        }
    }
}
