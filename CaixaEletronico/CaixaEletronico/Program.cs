using System;
using System.Text;

namespace CaixaEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valoresCedulas = new int[] { 100, 50, 20, 10, 5, 2 };

            int valorSaqueInicial = 188;
            int valorSaqueComparativo = valorSaqueInicial;

            StringBuilder resultadoPorCedula = new StringBuilder();

            int qtdCedulas = 0;

            for (int i = 0; i < valoresCedulas.Length; i++)
            {
                if (valorSaqueComparativo >= valoresCedulas[i])
                {
                    int qtdCedulasPorValor = valorSaqueComparativo / valoresCedulas[i];
                    int valorRestante = valorSaqueComparativo - (valoresCedulas[i] * qtdCedulasPorValor);

                    if (valorRestante >= 5 || valorRestante % 2 == 0)
                    {
                        resultadoPorCedula.AppendLine($"Valor da cédula: {valoresCedulas[i]} / Quantidade de cédulas: {qtdCedulasPorValor}");

                        qtdCedulas += qtdCedulasPorValor;
                        valorSaqueComparativo -= (valoresCedulas[i] * qtdCedulasPorValor);
                    }
                }
            }

            Console.WriteLine("Valor Saque Inicial: " + valorSaqueInicial);
            Console.WriteLine(resultadoPorCedula.ToString());
            Console.WriteLine("Total de cedulas: " + qtdCedulas);

            Console.ReadKey();
        }
    }
}
