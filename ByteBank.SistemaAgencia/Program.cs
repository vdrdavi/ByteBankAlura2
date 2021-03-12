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
            //string url = "pagina?argumentos";
            //int indiceInterrogação = url.IndexOf("?");
            //string argumentos = url.Substring(indiceInterrogação + 1);

            //string palavra = "moedaOrigem=real&moedaDestino=valor";
            //string nomeArgumento = "moedaDestino";

            //int indice = palavra.IndexOf(nomeArgumento);
            //int indiceValor = indice + nomeArgumento.Length;
            //string valorArgumento = palavra.Substring(indiceValor + 1);
            
            string url = "www.bytebank.com/cambio?origem=real&destino=dolar&valor=420";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);


            Console.WriteLine(extrator.GetValor("origem"));
            Console.WriteLine(extrator.GetValor("destino"));
            Console.WriteLine(extrator.GetValor("valor"));
            Console.ReadLine();
        }
    }
}