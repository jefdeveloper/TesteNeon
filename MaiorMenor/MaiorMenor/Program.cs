using System;

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array de entrada
            int[] array = new int[] { 2, 4, 5, 3, 40, 1, 8, 0 };

            //variavel para armazenar o maior valor
            int maior = 0;

            //variavel para armazenar o menor valor
            int menor = 0;

            //loop no arrray para identificar os valores
            for (int i = 0; i < array.Length; i++)
            {
                //se o valor do array for maior que o armazenado na variavel "maior", substituir o valor
                //caso nao, verifica se o valor do array é menor que o armazenado na variavel "menor", se for, substituir o valor
                if (array[i] > maior)
                    maior = array[i];
                else if (array[i] < menor)
                    menor = array[i];
            }

            //Printa o maior valor
            Console.WriteLine("Maior: " + maior);

            //Printa o menor valor
            Console.WriteLine("Menor: " + menor);

            Console.ReadKey();
        }
    }
}
