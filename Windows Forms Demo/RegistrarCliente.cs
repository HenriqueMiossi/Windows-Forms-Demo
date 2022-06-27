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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            ufCombobox.DataSource = Enum.GetValues(typeof(UnidadeFederativa));
            ufCombobox.SelectedItem = null;
            ufCombobox.SelectedText = "Escolha uma UF";

            tipoPessoaCombobox.Items.Add("Pessoa Física");
            tipoPessoaCombobox.Items.Add("Pessoa Jurídica");
            tipoPessoaCombobox.SelectedItem = null;
            tipoPessoaCombobox.SelectedText = "Escolha o tipo de Pessoa";

            if (tipoPessoaCombobox.SelectedItem == null)
            {
                codigoPessoa1Label.Visible = false;
                codigoPessoa1Input.Visible = false;

                codigoPessoa2Label.Visible = false;
                codigoPessoa2Input.Visible = false;

                nomePessoa1Label.Visible = false;
                nomePessoa1Input.Visible = false;

                nomePessoa2Label.Visible = false;
                nomePessoa2Input.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool inputsSaoValidos()
        {
            string[] requiredInputs = new string[]
            {
                codigoInput.Text,
                tipoPessoaCombobox.Text,
                codigoPessoa1Input.Text,
                nomePessoa1Input.Text,
                cepInput.Text,
                emailInput.Text,
                telefoneInput.Text
            };

            foreach (string input in requiredInputs)
            {
                if (input.Trim() == String.Empty)
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!!");
                    return false;
                }
            }

            return true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!inputsSaoValidos())
                return;

            if (tipoPessoaCombobox.SelectedItem.ToString() == "Pessoa Física")
            {
                Endereco endereco = new Endereco(
                    cepInput.Text,
                    logradouroInput.Text,
                    numeroInput.Text,
                    complementoInput.Text,
                    bairroInput.Text,
                    municipioInput.Text,
                    ufCombobox.Text
                    );

                PessoaFisica pessoaFisica = new PessoaFisica(
                    codigoInput.Text,
                    emailInput.Text,
                    telefoneInput.Text,
                    codigoPessoa1Input.Text,
                    codigoPessoa2Input.Text,
                    nomePessoa1Input.Text,
                    nomePessoa2Input.Text
                    );
                if (pessoaFisica.cpfEhUnico())
                {
                    endereco.registra();
                    pessoaFisica.registra();

                    MessageBox.Show("Cliente cadastrado com sucesso!!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("O CPF deve ser único!!");
                }
            }
            else
            {
                Endereco endereco = new Endereco(
                    cepInput.Text,
                    logradouroInput.Text,
                    numeroInput.Text,
                    complementoInput.Text,
                    bairroInput.Text,
                    municipioInput.Text,
                    ufCombobox.Text
                    );

                PessoaJuridica pessoaJuridica = new PessoaJuridica(
                    codigoInput.Text,
                    emailInput.Text,
                    telefoneInput.Text,
                    codigoPessoa1Input.Text,
                    codigoPessoa2Input.Text,
                    nomePessoa1Input.Text,
                    nomePessoa2Input.Text
                    );

                if (pessoaJuridica.cnpjEhUnico())
                {
                    endereco.registra();
                    pessoaJuridica.registra();

                    MessageBox.Show("Cliente cadastrado com sucesso!!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("O CNPJ deve ser único!!");
                }
            }
        }

        private void tipoPessoaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tipoPessoaCombobox.SelectedItem.ToString() == "Pessoa Física")
                {
                    codigoPessoa1Label.Text = "CPF *";
                    codigoPessoa1Label.Visible = true;
                    codigoPessoa1Input.Visible = true;

                    codigoPessoa2Label.Text = "RG";
                    codigoPessoa2Label.Visible = true;
                    codigoPessoa2Input.Visible = true;

                    nomePessoa1Label.Text = "Nome Completo";
                    nomePessoa1Label.Visible = true;
                    nomePessoa1Input.Visible = true;

                    nomePessoa2Label.Text = "Nome Abreviado";
                    nomePessoa2Label.Visible = true;
                    nomePessoa2Input.Visible = true;
                }

                else if (tipoPessoaCombobox.SelectedItem.ToString() == "Pessoa Jurídica")
                {
                    codigoPessoa1Label.Text = "CNPJ *";
                    codigoPessoa1Label.Visible = true;
                    codigoPessoa1Input.Visible = true;

                    codigoPessoa2Label.Text = "IE";
                    codigoPessoa2Label.Visible = true;
                    codigoPessoa2Input.Visible = true;

                    nomePessoa1Label.Text = "Razão Social";
                    nomePessoa1Label.Visible = true;
                    nomePessoa1Input.Visible = true;

                    nomePessoa2Label.Text = "Nome Fantasia";
                    nomePessoa2Label.Visible = true;
                    nomePessoa2Input.Visible = true;
                }
            }
            catch (Exception)
            {
                codigoPessoa1Label.Visible = false;
                codigoPessoa1Input.Visible = false;

                codigoPessoa2Label.Visible = false;
                codigoPessoa2Input.Visible = false;

                nomePessoa1Label.Visible = false;
                nomePessoa1Input.Visible = false;

                nomePessoa2Label.Visible = false;
                nomePessoa2Input.Visible = false;
            }
        }
    }
}
