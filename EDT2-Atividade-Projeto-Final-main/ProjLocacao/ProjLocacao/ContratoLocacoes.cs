using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLocacao
{
    class ContratoLocacoes
    {
        private List<ContratoLocacao> contratos;
        public List<ContratoLocacao> Contratos { get => contratos; set => contratos = value; }
        public ContratoLocacoes()
        {
            contratos = new List<ContratoLocacao>();
        }
        public void incluir(ContratoLocacao contratoLocacao)
        {
            contratoLocacao.Id = contratos.Count + 1;
            contratos.Add(contratoLocacao);
        }
    }
}
