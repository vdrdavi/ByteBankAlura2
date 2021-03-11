using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";
            int indiceInterrogação = url.IndexOf("?");
            string argumentos = url.Substring(indiceInterrogação + 1);
            Console.WriteLine(argumentos);
            Console.ReadLine();
        }
    }
}