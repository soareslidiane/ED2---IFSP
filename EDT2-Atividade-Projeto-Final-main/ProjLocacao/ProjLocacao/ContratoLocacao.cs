using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLocacao
{
    class ContratoLocacao
    {
        private int id;
        private bool liberado = false;
        private DateTime saida;
        private DateTime retorno;
        private Stack<TipoEquipamento> itens;
        TipoEquipamento tipoEquipamento = new TipoEquipamento();
        public int Id { get => id; set => id = value; }
        public bool Liberado { get => liberado; set => liberado = value; }
        public DateTime Saida { get => saida; set => saida = value; }
        public DateTime Retorno { get => retorno; set => retorno = value; }
        public Stack<TipoEquipamento> Itens { get => itens; set => itens = value; }
        public ContratoLocacao()
        {
            id = 0;
            liberado = false;
            saida = new DateTime();
            retorno = new DateTime();
            itens = new Stack<TipoEquipamento>();
        }
        public void incluir(TipoEquipamento tipoEquipamento)
        {
            tipoEquipamento.Id = itens.Count + 1;
            itens.Push(tipoEquipamento);
        }
        public TipoEquipamento buscar(string nome)
        {
            foreach (TipoEquipamento tipoequipamento in itens)
            {
                if (tipoequipamento.Nome == nome)
                    tipoEquipamento = tipoequipamento;
            }
            return tipoEquipamento;
        }
    }
}
