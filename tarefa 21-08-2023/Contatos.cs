using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefone
{
    internal class Contatos
    {

        private readonly List<Contato> agenda;

        public Contatos(List<Contato> agenda)
        {
            this.agenda = agenda;
        }

        public Contatos()
        {
            agenda = new List<Contato>();
        }

        internal List<Contato> Agenda => agenda;

        public bool adicionar(Contato c)
        {
            bool add = true;
           Agenda.Add(c);
            return add;
        }

        public Contato pesquisar(Contato c)
        {
            Contato contatos = new Contato();

            foreach (Contato s in Agenda)
            {
                if (s.Email.Equals(c.Email))
                {
                    contatos = s;
                }
            }

            return contatos;
        }

        public bool alterar(Contato c)
        {
            bool alterar = false;
            foreach (Contato s in Agenda)
            {
                if (s.Email.Equals(c.Email))
                {
                    s.Nome = c.Nome;
                    s.Telefones = c.Telefones;
                    s.DtNasc = c.DtNasc;
                    alterar = true;
                }
            }
            return alterar;
        }

        public bool remover(Contato c)
        {
            bool remove = false;
            foreach (Contato s in Agenda.ToList())
            {
                if (s.Email.Equals(c.Email))
                {
                    agenda.Remove(s);
                    remove = true;
                }
            }
            return remove;
        }
        
    }
}
