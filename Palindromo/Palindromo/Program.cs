using System;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Palavra recebida como input
            string palavraRecebida = "asas";

            //String que será concatenada com a palavra recebida como input de forma inversa
            string palavraInvertida = "";

            //Efetuar loop na palavra recebida para inverte-la
            for (int i = palavraRecebida.Length - 1; i >= 0; i--)
            {
                palavraInvertida += palavraRecebida.Substring(i, 1);
            }

            //compara a palavra recebida com a invertida
            bool isEqual = string.Equals(palavraRecebida, palavraInvertida);

            //Printa no Console o resultado
            if (isEqual)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");

            Console.ReadKey();
        }
    }
}
