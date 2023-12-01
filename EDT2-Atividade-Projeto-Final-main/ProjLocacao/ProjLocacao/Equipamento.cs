using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLocacao
{
    class Equipamento
    {
        private int id;
        private bool avariado;
        private bool locado;
        public int Id { get => id; set => id = value; }
        public bool Avariado { get => avariado; set => avariado = value; }
        public bool Locado { get => locado; set => locado = value; }
        public Equipamento()
        {
            id = 0;
            avariado = false;
            locado = false;
        }
    }
}
