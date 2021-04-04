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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            lista.Adicionar(new ContaCorrente(222, 3425435));
            lista.Adicionar(new ContaCorrente(123, 5675675));
            lista.Adicionar(new ContaCorrente(345, 5345645));
            lista.Adicionar(new ContaCorrente(895, 1234124));

            ContaCorrente conta = lista.GetItemNoindice(2);
            Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            Console.ReadLine();
        }
    }
}