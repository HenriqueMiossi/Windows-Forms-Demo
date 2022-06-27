using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Demo
{
    class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string municipio, string uf)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            Uf = uf;
        }

        public void registra()
        {
            Database db = new Database();

            db.cadastraEndereco(
                this.Cep,
                this.Logradouro,
                this.Numero,
                this.Complemento,
                this.Bairro,
                this.Municipio,
                this.Uf.ToString()
                );
        }
    }
}
