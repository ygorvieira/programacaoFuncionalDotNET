using System;

namespace Capitulo02Csharp
{
    public class PeriodoDeTempo
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public bool VerificarSeDataEstaEntreOPeriodo(DateTime dataParaTestar)
        {
            return dataParaTestar.CompareTo(DataInicial) >= 0 && dataParaTestar.CompareTo(DataFinal) <= 0;
        }

        public void AdicionaDias(int dias)
        {
            DataInicial = DataInicial.AddDays(dias);
            DataFinal = DataFinal.AddDays(dias);
        }
    }
}
