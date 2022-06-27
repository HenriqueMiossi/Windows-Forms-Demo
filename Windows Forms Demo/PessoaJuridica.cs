using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Demo
{
    class PessoaJuridica : TipoPessoa
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        public PessoaJuridica(string codigo, string email, string telefone, string cnpj, string ie, string razaoSocial, string nomeFantasia)
        {
            this.Tipo = "Pessoa Jurídica";
            this.Codigo = codigo;
            this.Email = email;
            this.Telefone = telefone;
            this.Cnpj = cnpj;
            this.Ie = ie;
            this.RazaoSocial = razaoSocial;
            this.NomeFantasia = nomeFantasia;
        }

        public bool cnpjEhUnico()
        {
            Database db = new Database();

            if (!db.contemDuplicata("cnpj", this.Cnpj))
                return true;

            return false;
        }
        public void registra()
        {
            Database db = new Database();

            db.cadastraClientePessoaJuridica(
                this.Codigo,
                this.Cnpj,
                this.Ie,
                this.RazaoSocial,
                this.NomeFantasia,
                this.Email,
                this.Telefone
                );
        }

        public void edita(int id)
        {
            Database db = new Database();

            db.editaClientePessoaJuridica(
                id,
                this.Codigo,
                this.Cnpj,
                this.Ie,
                this.RazaoSocial,
                this.NomeFantasia,
                this.Email,
                this.Telefone
                );
        }
    }
}
