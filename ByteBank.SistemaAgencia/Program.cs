﻿using System;
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
            #region string
            //string padrao = "[0-9]{4,5}[-, ]?[0-9]{4}";
            //string texto = "Meu número é: 94324 2437";
            //Match match = Regex.Match(texto, padrao);
            //Console.WriteLine(match);
            //Console.ReadLine();

            //string url = "www.bytebank.com/cambio?origem=real&destino=dolar&valor=420";
            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);


            //Console.WriteLine(extrator.GetValor("origem"));
            //Console.WriteLine(extrator.GetValor("destino"));
            //Console.WriteLine(extrator.GetValor("VALOR")); 
            #endregion
            ContaCorrente conta = new ContaCorrente(293, 23000);
            Console.WriteLine(conta);
            
            
            Cliente carlos1 = new Cliente();
            carlos1.Nome = "Carlos";
            carlos1.CPF = "123.456.432-03";
            carlos1.Profissao = "Desenvolvedor";
            Cliente carlos2 = new Cliente();
            carlos2.Nome = "Carlos";
            carlos2.CPF = "123.456.432-03";
            carlos2.Profissao = "Desenvolvedor";

            if (carlos1.Equals(carlos2))
            {
                Console.WriteLine("São iguais!");
            }
            Console.ReadLine();
        }
    }
}