using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Demo
{
    class PessoaFisica : TipoPessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }

        public PessoaFisica(string codigo, string email, string telefone, string cpf, string rg, string nome, string nomeAbreviado)
        {
            this.Tipo = "Pessoa Física";
            this.Codigo = codigo;
            this.Email = email;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Nome = nome;
            this.NomeAbreviado = nomeAbreviado;
        }

        public bool cpfEhUnico()
        {
            Database db = new Database();

            if (!db.contemDuplicata("cpf", this.Cpf))
                return true;

            return false;
        }

        public void registra()
        {
            Database db = new Database();

            db.cadastraClientePessoaFisica(
                this.Codigo,
                this.Cpf,
                this.Rg,
                this.Nome,
                this.NomeAbreviado,
                this.Email,
                this.Telefone
                );
        }

        public void edita(int id)
        {
            Database db = new Database();

            db.editaClientePessoaFisica(
                id,
                this.Codigo,
                this.Cpf,
                this.Rg,
                this.Nome,
                this.NomeAbreviado,
                this.Email,
                this.Telefone
                );
        }
    }
}
