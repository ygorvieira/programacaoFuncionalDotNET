using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo02Csharp
{
    public class PeriodoDeTempoImutavel
    {
        public PeriodoDeTempoImutavel(DateTime dataInicial, DateTime dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }

        public DateTime DataInicial { get; }
        public DateTime DataFinal { get; }

        public static bool VerificarSeDataEstaEntreOPeriodo(PeriodoDeTempoImutavel periodo, DateTime dataParaTestar)
        {
            return dataParaTestar.CompareTo(periodo.DataInicial) >= 0 && dataParaTestar.CompareTo(periodo.DataFinal) <= 0;
        }

        public static PeriodoDeTempoImutavel AdicionaDias(PeriodoDeTempoImutavel periodo, int dias)
        {
            return new PeriodoDeTempoImutavel(periodo.DataInicial.AddDays(dias), periodo.DataFinal.AddDays(dias));
        }
    }
}
