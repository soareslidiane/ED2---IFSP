using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLocacao
{
    class TipoEquipamento
    {
        private int id;
        private string nome;
        private List<Equipamento> itens;
        Equipamento equipamento = new Equipamento();
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Equipamento> Itens { get => itens; set => itens = value; }
        public TipoEquipamento()
        {
            id = 0;
            nome = "";
            itens = new List<Equipamento>();
        }
        public void incluir(Equipamento equipamento)
        {
            equipamento.Id = itens.Count + 1;
            itens.Add(equipamento);
        }
        public Equipamento buscar(int id)
        {
            foreach (Equipamento x in itens)
            {
                if (x.Id == id)
                    equipamento = x;
            }
            return equipamento;
        }
    }
}
