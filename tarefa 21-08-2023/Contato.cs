using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefone
{
    internal class Contato : IEquatable<Contato?>
    {
        private string email;
        private string nome;
        private Data dtNasc;
        private string telefones;

        public Contato(string email, string nome, Data dtNasc, string telefones)
        {
            this.email = email;
            this.nome = nome;
            this.dtNasc = dtNasc;
            this.telefones = telefones;
        }



        public Contato()
        {
        }

        public Contato(string telefones)
        {
            this.telefones = telefones;
        }

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Data DtNasc { get => dtNasc; set => dtNasc = value; }
        internal string Telefones { get => telefones; set => telefones = value; }
        public string? Telefone { get; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Contato);
        }

        public bool Equals(Contato? other)
        {
            return other is not null;
        }

 

            public int getIdate()
        {
            return 2023 - dtNasc.Ano;
        }

        public string adicionarTelefone(Telefone t)
        {
            return t.Numero;

        }



        public override string ToString()
        {
            return email + " - " + nome + " - " + telefones + " - " + dtNasc.ToString();
        }

    }
}
