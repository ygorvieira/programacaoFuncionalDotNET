using System.Linq;

namespace Capitulo01CSharp
{
    class Calculadora
    {
        public int ElevaNumeroAoQuadradao(int numero)
        {
            return numero * numero;
        }

        public int SomaQuadradoDosNumerosAteDez()
        {
            return Enumerable.Range(1, 10)
                            .Select(ElevaNumeroAoQuadradao)
                            .Sum();
        }
    }
}
