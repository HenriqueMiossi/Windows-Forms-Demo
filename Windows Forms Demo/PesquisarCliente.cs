using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Demo
{
    public partial class PesquisarCliente : Form
    {
        private Database db = new Database();
        private string filtro;

        public PesquisarCliente()
        {
            InitializeComponent();
        }

        private void PesquisarCliente_Load(object sender, EventArgs e)
        {
            searchComboBox.Items.Add("CPF");
            searchComboBox.Items.Add("CNPJ");
            searchComboBox.Items.Add("Nome");
            searchComboBox.Items.Add("Razão Social");
            searchComboBox.SelectedItem = null;
            searchComboBox.SelectedText = "Escolha o filtro de pesquisa";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchComboBox.SelectedItem != null)
            {
                filtro = searchComboBox.SelectedItem.ToString();
                DataTable result = db.pesquisaCliente(filtro, valorInput.Text);
                clienteGridView.DataSource = result;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (clienteGridView.SelectedRows.Count > 0 &&
                clienteGridView.SelectedRows[0].Index !=
                clienteGridView.Rows.Count - 1)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente remover esse cliente?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int index = clienteGridView.SelectedRows[0].Index;
                        int id = (int) clienteGridView.SelectedRows[0].Cells[0].Value;
                        db.removeCliente(filtro, id);

                        clienteGridView.Rows.RemoveAt(index);

                        MessageBox.Show("Cliente removido com sucesso!");
                    }
                    catch (Exception exception)
                    {
                        Debug.WriteLine(exception.Message);
                    }
                }
            }
        }

        private void clienteGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = clienteGridView.SelectedCells[0].RowIndex;

            DataGridViewRow row = clienteGridView.Rows[linhaIndex];

            int id = (int) clienteGridView.Rows[linhaIndex].Cells[0].Value;

            switch (filtro)
            {
                case "CPF": case "Nome":
                    PessoaFisica pessoaFisica = new PessoaFisica(
                        row.Cells[1].Value.ToString(),
                        row.Cells[6].Value.ToString(),
                        row.Cells[7].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(),
                        row.Cells[5].Value.ToString()
                        );

                    pessoaFisica.edita(id);

                    break;
                case "CNPJ": case "Razão Social":
                    PessoaJuridica pessoaJuridica = new PessoaJuridica(
                        row.Cells[1].Value.ToString(),
                        row.Cells[6].Value.ToString(),
                        row.Cells[7].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(),
                        row.Cells[5].Value.ToString()
                        );

                    pessoaJuridica.edita(id);

                    break;
                default:
                    break;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
