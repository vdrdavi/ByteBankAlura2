using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // O valor padrão é utilizado em todas as posições de um array ao ser criado.
            int[] idades = new int[] { 12, 34, 46, 21, 19 };            

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                acumulador += idades[indice];
            }
            int media = acumulador / idades.Length;
            Console.WriteLine(media);

            Console.ReadLine();
        }
    }
}