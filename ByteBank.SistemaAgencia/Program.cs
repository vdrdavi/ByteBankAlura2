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
            string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string texto = "Meu número é: 4324-2437";
            Match match = Regex.Match(texto, padrao);
            Console.WriteLine(match);
            Console.ReadLine();

            string url = "www.bytebank.com/cambio?origem=real&destino=dolar&valor=420";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);


            Console.WriteLine(extrator.GetValor("origem"));
            Console.WriteLine(extrator.GetValor("destino"));
            Console.WriteLine(extrator.GetValor("VALOR"));
            Console.ReadLine();
        }
    }
}