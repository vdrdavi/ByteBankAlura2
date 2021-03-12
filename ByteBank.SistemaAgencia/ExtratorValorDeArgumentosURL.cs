﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; set; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }
            URL = url;
            int indiceInterrogação = url.IndexOf("?");
            _argumentos = url.Substring(indiceInterrogação + 1);
        }
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentosEmCaixaAlta = _argumentos.ToUpper();
            string termo = nomeParametro + "=";
            int indiceTermos = argumentosEmCaixaAlta.IndexOf(termo);
            string resultado = _argumentos.Substring(indiceTermos + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');
            if (indiceEComercial == -1)
            {
                return resultado;
            }
            return resultado.Remove(indiceEComercial);
        }
    }
}
