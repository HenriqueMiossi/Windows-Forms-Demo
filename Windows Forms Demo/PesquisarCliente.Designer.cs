namespace Windows_Forms_Demo
{
    partial class PesquisarCliente
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clienteGridView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.valorInput = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(141, 62);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(97, 20);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Pesquisar por";
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(244, 59);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(227, 28);
            this.searchComboBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(244, 163);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 50);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Pesquisar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clienteGridView
            // 
            this.clienteGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.clienteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteGridView.Location = new System.Drawing.Point(60, 270);
            this.clienteGridView.Name = "clienteGridView";
            this.clienteGridView.RowHeadersWidth = 51;
            this.clienteGridView.RowTemplate.Height = 29;
            this.clienteGridView.Size = new System.Drawing.Size(494, 311);
            this.clienteGridView.TabIndex = 3;
            this.clienteGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteGridView_CellValueChanged);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeButton.Location = new System.Drawing.Point(228, 605);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(160, 50);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remover Cliente";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // valorInput
            // 
            this.valorInput.Location = new System.Drawing.Point(141, 115);
            this.valorInput.Name = "valorInput";
            this.valorInput.Size = new System.Drawing.Size(330, 27);
            this.valorInput.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Voltar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clique duas vezes em um campo para editar";
            // 
            // PesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.valorInput);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.clienteGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchLabel);
            this.Name = "PesquisarCliente";
            this.Text = "PesquisarCliente";
            this.Load += new System.EventHandler(this.PesquisarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label searchLabel;
        private ComboBox searchComboBox;
        private Button searchButton;
        private DataGridView clienteGridView;
        private Button removeButton;
        private TextBox valorInput;
        private Button backButton;
        private Label label1;
    }
}