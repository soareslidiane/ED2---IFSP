using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLocacao
{
    class Equipamentos
    {
        private List<TipoEquipamento> estoque;
        TipoEquipamento tipoequipamento = new TipoEquipamento();
        public List<TipoEquipamento> Estoque { get => estoque; set => estoque = value; }
        public Equipamentos()
        {
            estoque = new List<TipoEquipamento>();
        }
        public void incluir(TipoEquipamento tipoqEquipamento)
        {
            tipoqEquipamento.Id = estoque.Count + 1;
            estoque.Add(tipoqEquipamento);
        }
        public TipoEquipamento buscar(string nome)
        {
            foreach (TipoEquipamento tipoEquipamento in estoque)
            {
                if (tipoEquipamento.Nome == nome)
                    tipoequipamento = tipoEquipamento;
            }
            return tipoequipamento;
        }
    }
}
