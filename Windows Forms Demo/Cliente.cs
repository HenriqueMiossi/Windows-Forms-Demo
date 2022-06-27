using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Demo
{
    class Cliente
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime Inclusao { get; set; }
        public DateTime Alteracao { get; set; }
        public bool Bloqueado { get; set; }

        public Cliente(TipoPessoa tipoPessoa)
        {
            TipoPessoa = tipoPessoa;
        }
    }
}
