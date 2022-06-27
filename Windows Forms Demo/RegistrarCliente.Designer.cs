namespace Windows_Forms_Demo
{
    partial class RegistrarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.telefoneInput = new System.Windows.Forms.TextBox();
            this.cepLabel = new System.Windows.Forms.Label();
            this.logradouroLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.complementoLabel = new System.Windows.Forms.Label();
            this.bairroLabel = new System.Windows.Forms.Label();
            this.municipioLabel = new System.Windows.Forms.Label();
            this.cepInput = new System.Windows.Forms.TextBox();
            this.logradouroInput = new System.Windows.Forms.TextBox();
            this.numeroInput = new System.Windows.Forms.TextBox();
            this.complementoInput = new System.Windows.Forms.TextBox();
            this.bairroInput = new System.Windows.Forms.TextBox();
            this.municipioInput = new System.Windows.Forms.TextBox();
            this.ufCombobox = new System.Windows.Forms.ComboBox();
            this.unidadeFederativaLabel = new System.Windows.Forms.Label();
            this.tipoPessoaCombobox = new System.Windows.Forms.ComboBox();
            this.tipoPessoaLabel = new System.Windows.Forms.Label();
            this.codigoPessoa1Label = new System.Windows.Forms.Label();
            this.codigoPessoa2Label = new System.Windows.Forms.Label();
            this.nomePessoa1Label = new System.Windows.Forms.Label();
            this.nomePessoa2Label = new System.Windows.Forms.Label();
            this.codigoPessoa1Input = new System.Windows.Forms.TextBox();
            this.codigoPessoa2Input = new System.Windows.Forms.TextBox();
            this.nomePessoa1Input = new System.Windows.Forms.TextBox();
            this.nomePessoa2Input = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.codigoInput = new System.Windows.Forms.TextBox();
            this.requiredFieldsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Voltar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(47, 153);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(222, 27);
            this.emailInput.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(553, 562);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 45);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(47, 130);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(56, 20);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email *";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(47, 198);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(76, 20);
            this.telefoneLabel.TabIndex = 4;
            this.telefoneLabel.Text = "Telefone *";
            // 
            // telefoneInput
            // 
            this.telefoneInput.Location = new System.Drawing.Point(47, 221);
            this.telefoneInput.Name = "telefoneInput";
            this.telefoneInput.Size = new System.Drawing.Size(222, 27);
            this.telefoneInput.TabIndex = 5;
            // 
            // cepLabel
            // 
            this.cepLabel.AutoSize = true;
            this.cepLabel.Location = new System.Drawing.Point(411, 62);
            this.cepLabel.Name = "cepLabel";
            this.cepLabel.Size = new System.Drawing.Size(44, 20);
            this.cepLabel.TabIndex = 6;
            this.cepLabel.Text = "CEP *";
            // 
            // logradouroLabel
            // 
            this.logradouroLabel.AutoSize = true;
            this.logradouroLabel.Location = new System.Drawing.Point(411, 130);
            this.logradouroLabel.Name = "logradouroLabel";
            this.logradouroLabel.Size = new System.Drawing.Size(87, 20);
            this.logradouroLabel.TabIndex = 7;
            this.logradouroLabel.Text = "Logradouro";
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(411, 198);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(63, 20);
            this.numeroLabel.TabIndex = 8;
            this.numeroLabel.Text = "Número";
            // 
            // complementoLabel
            // 
            this.complementoLabel.AutoSize = true;
            this.complementoLabel.Location = new System.Drawing.Point(411, 266);
            this.complementoLabel.Name = "complementoLabel";
            this.complementoLabel.Size = new System.Drawing.Size(104, 20);
            this.complementoLabel.TabIndex = 9;
            this.complementoLabel.Text = "Complemento";
            // 
            // bairroLabel
            // 
            this.bairroLabel.AutoSize = true;
            this.bairroLabel.Location = new System.Drawing.Point(411, 334);
            this.bairroLabel.Name = "bairroLabel";
            this.bairroLabel.Size = new System.Drawing.Size(49, 20);
            this.bairroLabel.TabIndex = 10;
            this.bairroLabel.Text = "Bairro";
            // 
            // municipioLabel
            // 
            this.municipioLabel.AutoSize = true;
            this.municipioLabel.Location = new System.Drawing.Point(411, 402);
            this.municipioLabel.Name = "municipioLabel";
            this.municipioLabel.Size = new System.Drawing.Size(75, 20);
            this.municipioLabel.TabIndex = 11;
            this.municipioLabel.Text = "Município";
            // 
            // cepInput
            // 
            this.cepInput.Location = new System.Drawing.Point(411, 85);
            this.cepInput.Name = "cepInput";
            this.cepInput.Size = new System.Drawing.Size(222, 27);
            this.cepInput.TabIndex = 12;
            // 
            // logradouroInput
            // 
            this.logradouroInput.Location = new System.Drawing.Point(411, 153);
            this.logradouroInput.Name = "logradouroInput";
            this.logradouroInput.Size = new System.Drawing.Size(222, 27);
            this.logradouroInput.TabIndex = 13;
            // 
            // numeroInput
            // 
            this.numeroInput.Location = new System.Drawing.Point(411, 221);
            this.numeroInput.Name = "numeroInput";
            this.numeroInput.Size = new System.Drawing.Size(222, 27);
            this.numeroInput.TabIndex = 14;
            // 
            // complementoInput
            // 
            this.complementoInput.Location = new System.Drawing.Point(411, 289);
            this.complementoInput.Name = "complementoInput";
            this.complementoInput.Size = new System.Drawing.Size(222, 27);
            this.complementoInput.TabIndex = 15;
            // 
            // bairroInput
            // 
            this.bairroInput.Location = new System.Drawing.Point(411, 357);
            this.bairroInput.Name = "bairroInput";
            this.bairroInput.Size = new System.Drawing.Size(222, 27);
            this.bairroInput.TabIndex = 16;
            // 
            // municipioInput
            // 
            this.municipioInput.Location = new System.Drawing.Point(411, 425);
            this.municipioInput.Name = "municipioInput";
            this.municipioInput.Size = new System.Drawing.Size(222, 27);
            this.municipioInput.TabIndex = 17;
            // 
            // ufCombobox
            // 
            this.ufCombobox.FormattingEnabled = true;
            this.ufCombobox.Location = new System.Drawing.Point(411, 493);
            this.ufCombobox.Name = "ufCombobox";
            this.ufCombobox.Size = new System.Drawing.Size(151, 28);
            this.ufCombobox.TabIndex = 18;
            // 
            // unidadeFederativaLabel
            // 
            this.unidadeFederativaLabel.AutoSize = true;
            this.unidadeFederativaLabel.Location = new System.Drawing.Point(411, 470);
            this.unidadeFederativaLabel.Name = "unidadeFederativaLabel";
            this.unidadeFederativaLabel.Size = new System.Drawing.Size(138, 20);
            this.unidadeFederativaLabel.TabIndex = 19;
            this.unidadeFederativaLabel.Text = "Unidade Federativa";
            // 
            // tipoPessoaCombobox
            // 
            this.tipoPessoaCombobox.FormattingEnabled = true;
            this.tipoPessoaCombobox.Location = new System.Drawing.Point(47, 288);
            this.tipoPessoaCombobox.Name = "tipoPessoaCombobox";
            this.tipoPessoaCombobox.Size = new System.Drawing.Size(222, 28);
            this.tipoPessoaCombobox.TabIndex = 20;
            this.tipoPessoaCombobox.SelectedIndexChanged += new System.EventHandler(this.tipoPessoaCombobox_SelectedIndexChanged);
            // 
            // tipoPessoaLabel
            // 
            this.tipoPessoaLabel.AutoSize = true;
            this.tipoPessoaLabel.Location = new System.Drawing.Point(47, 266);
            this.tipoPessoaLabel.Name = "tipoPessoaLabel";
            this.tipoPessoaLabel.Size = new System.Drawing.Size(118, 20);
            this.tipoPessoaLabel.TabIndex = 21;
            this.tipoPessoaLabel.Text = "Tipo de Pessoa *";
            // 
            // codigoPessoa1Label
            // 
            this.codigoPessoa1Label.AutoSize = true;
            this.codigoPessoa1Label.Location = new System.Drawing.Point(47, 334);
            this.codigoPessoa1Label.Name = "codigoPessoa1Label";
            this.codigoPessoa1Label.Size = new System.Drawing.Size(50, 20);
            this.codigoPessoa1Label.TabIndex = 22;
            this.codigoPessoa1Label.Text = "label1";
            // 
            // codigoPessoa2Label
            // 
            this.codigoPessoa2Label.AutoSize = true;
            this.codigoPessoa2Label.Location = new System.Drawing.Point(47, 402);
            this.codigoPessoa2Label.Name = "codigoPessoa2Label";
            this.codigoPessoa2Label.Size = new System.Drawing.Size(50, 20);
            this.codigoPessoa2Label.TabIndex = 23;
            this.codigoPessoa2Label.Text = "label2";
            // 
            // nomePessoa1Label
            // 
            this.nomePessoa1Label.AutoSize = true;
            this.nomePessoa1Label.Location = new System.Drawing.Point(47, 470);
            this.nomePessoa1Label.Name = "nomePessoa1Label";
            this.nomePessoa1Label.Size = new System.Drawing.Size(50, 20);
            this.nomePessoa1Label.TabIndex = 24;
            this.nomePessoa1Label.Text = "label3";
            // 
            // nomePessoa2Label
            // 
            this.nomePessoa2Label.AutoSize = true;
            this.nomePessoa2Label.Location = new System.Drawing.Point(47, 538);
            this.nomePessoa2Label.Name = "nomePessoa2Label";
            this.nomePessoa2Label.Size = new System.Drawing.Size(50, 20);
            this.nomePessoa2Label.TabIndex = 25;
            this.nomePessoa2Label.Text = "label4";
            // 
            // codigoPessoa1Input
            // 
            this.codigoPessoa1Input.Location = new System.Drawing.Point(47, 357);
            this.codigoPessoa1Input.Name = "codigoPessoa1Input";
            this.codigoPessoa1Input.Size = new System.Drawing.Size(222, 27);
            this.codigoPessoa1Input.TabIndex = 26;
            // 
            // codigoPessoa2Input
            // 
            this.codigoPessoa2Input.Location = new System.Drawing.Point(47, 425);
            this.codigoPessoa2Input.Name = "codigoPessoa2Input";
            this.codigoPessoa2Input.Size = new System.Drawing.Size(222, 27);
            this.codigoPessoa2Input.TabIndex = 27;
            // 
            // nomePessoa1Input
            // 
            this.nomePessoa1Input.Location = new System.Drawing.Point(47, 493);
            this.nomePessoa1Input.Name = "nomePessoa1Input";
            this.nomePessoa1Input.Size = new System.Drawing.Size(222, 27);
            this.nomePessoa1Input.TabIndex = 28;
            // 
            // nomePessoa2Input
            // 
            this.nomePessoa2Input.Location = new System.Drawing.Point(47, 562);
            this.nomePessoa2Input.Name = "nomePessoa2Input";
            this.nomePessoa2Input.Size = new System.Drawing.Size(222, 27);
            this.nomePessoa2Input.TabIndex = 29;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(47, 62);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(68, 20);
            this.codigoLabel.TabIndex = 30;
            this.codigoLabel.Text = "Código *";
            // 
            // codigoInput
            // 
            this.codigoInput.Location = new System.Drawing.Point(47, 85);
            this.codigoInput.Name = "codigoInput";
            this.codigoInput.Size = new System.Drawing.Size(222, 27);
            this.codigoInput.TabIndex = 31;
            // 
            // requiredFieldsLabel
            // 
            this.requiredFieldsLabel.AutoSize = true;
            this.requiredFieldsLabel.Location = new System.Drawing.Point(472, 16);
            this.requiredFieldsLabel.Name = "requiredFieldsLabel";
            this.requiredFieldsLabel.Size = new System.Drawing.Size(161, 20);
            this.requiredFieldsLabel.TabIndex = 32;
            this.requiredFieldsLabel.Text = "Campos Obrigatórios *";
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 619);
            this.Controls.Add(this.requiredFieldsLabel);
            this.Controls.Add(this.codigoInput);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.nomePessoa2Input);
            this.Controls.Add(this.nomePessoa1Input);
            this.Controls.Add(this.codigoPessoa2Input);
            this.Controls.Add(this.codigoPessoa1Input);
            this.Controls.Add(this.nomePessoa2Label);
            this.Controls.Add(this.nomePessoa1Label);
            this.Controls.Add(this.codigoPessoa2Label);
            this.Controls.Add(this.codigoPessoa1Label);
            this.Controls.Add(this.tipoPessoaLabel);
            this.Controls.Add(this.tipoPessoaCombobox);
            this.Controls.Add(this.unidadeFederativaLabel);
            this.Controls.Add(this.ufCombobox);
            this.Controls.Add(this.municipioInput);
            this.Controls.Add(this.bairroInput);
            this.Controls.Add(this.complementoInput);
            this.Controls.Add(this.numeroInput);
            this.Controls.Add(this.logradouroInput);
            this.Controls.Add(this.cepInput);
            this.Controls.Add(this.municipioLabel);
            this.Controls.Add(this.bairroLabel);
            this.Controls.Add(this.complementoLabel);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.logradouroLabel);
            this.Controls.Add(this.cepLabel);
            this.Controls.Add(this.telefoneInput);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.backButton);
            this.Name = "RegistrarCliente";
            this.Text = "RegistrarCliente";
            this.Load += new System.EventHandler(this.RegistrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private TextBox emailInput;
        private Button saveButton;
        private Label emailLabel;
        private Label telefoneLabel;
        private TextBox telefoneInput;
        private Label cepLabel;
        private Label logradouroLabel;
        private Label numeroLabel;
        private Label complementoLabel;
        private Label bairroLabel;
        private Label municipioLabel;
        private TextBox cepInput;
        private TextBox logradouroInput;
        private TextBox numeroInput;
        private TextBox complementoInput;
        private TextBox bairroInput;
        private TextBox municipioInput;
        private ComboBox ufCombobox;
        private Label unidadeFederativaLabel;
        private ComboBox tipoPessoaCombobox;
        private Label tipoPessoaLabel;
        private Label codigoPessoa1Label;
        private Label codigoPessoa2Label;
        private Label nomePessoa1Label;
        private Label nomePessoa2Label;
        private TextBox codigoPessoa1Input;
        private TextBox codigoPessoa2Input;
        private TextBox nomePessoa1Input;
        private TextBox nomePessoa2Input;
        private Label codigoLabel;
        private TextBox codigoInput;
        private Label requiredFieldsLabel;
    }
}