using System;

namespace CalculandoEstatísticasSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numeroQtd = 6;
            int[] numeros = new int[numeroQtd];
            int menor = 0;
            int maior = 0;
            int contador=0;
            float media = 0;
            float soma = 0;
            

            Console.WriteLine("Informe números inteiros:");

            for (int i = 0; i < numeroQtd; i++)
            {
                Console.WriteLine((i + 1) + "º número:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                menor=numeros[0];

                if (numeros[i] < menor)
                {
                    
                    menor = numeros[i];

                }
                else if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

                for(int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[j] == numeros[j])
                    {
                        contador++;
                        break;
                    }
                }
                
                    soma = soma + numeros[i];
                    media = soma / 6;


        }
            Console.WriteLine("O Valor mínimo é:" + menor);
            Console.WriteLine("O Valor máximo é:" + maior);
            Console.WriteLine("O Número de elementos na seqüência é:" + contador);
            Console.WriteLine("A média é:" + media);
        }
    }
}

