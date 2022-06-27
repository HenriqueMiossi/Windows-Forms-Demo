using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Demo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrarCliente telaRegistro = new RegistrarCliente();
            telaRegistro.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            PesquisarCliente telaPesquisa = new PesquisarCliente();
            telaPesquisa.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
