using System;

namespace Exercio9Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            OperaVetor operaVetor = new OperaVetor();
            int resultSomaPar;
            int resultSomaImpar;


            operaVetor.populaVetor();
            resultSomaPar = operaVetor.SomaPares();
            resultSomaImpar = operaVetor.SomaImpares();

            Console.WriteLine("Resultado da soma dos Pares: {0}", resultSomaPar);
            Console.WriteLine("Resultado da soma dos Impares: {0}", resultSomaImpar);
        }
    }
}