﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefone
{
    internal class Telefone
    {

        private string tipo;
        private string numero;
        private bool principal;

        public Telefone(string tipo, string numero, bool principal)
        {
            this.Tipo = tipo;
            this.Numero = numero;
            this.Principal = principal;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Numero { get => numero; set => numero = value; }
        public bool Principal { get => principal; set => principal = value; }
    }
}
