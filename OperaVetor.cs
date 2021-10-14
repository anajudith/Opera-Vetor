using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercio9Prova
{
    class OperaVetor
    {
        Random rnd = new Random();
        private int[] V;
        private int Tamanho;
        int valorVetor;
        int Soma = 0;
        int Impar = 0;

        public OperaVetor()

        {
            Console.Write("Tamanho do Vetor: ");
            Tamanho = int.Parse(Console.ReadLine());

            V = new int[Tamanho];
        }

        public OperaVetor(int Tamanho)
        {
            V = new int[Tamanho];
        }

        public void populaVetor()
        {
            for(int i = 0; i < V.Length; i++)
            {
                Console.WriteLine("Insira um valor para o vetor");
                valorVetor = int.Parse(Console.ReadLine());
                V[i] = valorVetor;
            }
        }

        public int SomaPares()
        {
            foreach(int value in V)
            {
                if(value % 2 == 0)
                {
                    Soma += value;
                }
            }
            return Soma;
        }

        public int SomaImpares()
        {
            foreach(int value in V)
            {
                if(value % 2 !=0)
                {
                    Impar += value;
                }
            }
            return Impar;
        }

    }
}