using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Demo
{
    abstract class TipoPessoa
    {
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
