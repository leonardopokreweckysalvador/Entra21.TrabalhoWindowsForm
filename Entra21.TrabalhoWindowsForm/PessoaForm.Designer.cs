namespace Entra21.TrabalhoWindowsForm
{
    partial class PessoaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelRg = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEndereco = new System.Windows.Forms.ComboBox();
            this.checkBoxCarro = new System.Windows.Forms.CheckBox();
            this.checkBoxMoto = new System.Windows.Forms.CheckBox();
            this.labelPossuiVeiculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(561, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(498, 9);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(417, 9);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(594, 38);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(594, 83);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.labelDataNascimento.TabIndex = 4;
            this.labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(594, 131);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 15);
            this.labelEndereco.TabIndex = 5;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(594, 175);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(32, 15);
            this.labelSexo.TabIndex = 6;
            this.labelSexo.Text = "Sexo";
            this.labelSexo.Click += new System.EventHandler(this.labelSexo_Click);
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(594, 222);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(28, 15);
            this.labelCpf.TabIndex = 7;
            this.labelCpf.Text = "CPF";
            // 
            // labelRg
            // 
            this.labelRg.AutoSize = true;
            this.labelRg.Location = new System.Drawing.Point(594, 269);
            this.labelRg.Name = "labelRg";
            this.labelRg.Size = new System.Drawing.Size(22, 15);
            this.labelRg.TabIndex = 8;
            this.labelRg.Text = "RG";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(594, 56);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(310, 23);
            this.textBoxNome.TabIndex = 9;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(594, 101);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(310, 23);
            this.dateTimePickerDataNascimento.TabIndex = 10;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(594, 193);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(310, 23);
            this.comboBoxSexo.TabIndex = 14;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(748, 372);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 15;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(829, 372);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(594, 240);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(310, 23);
            this.maskedTextBoxCpf.TabIndex = 17;
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Location = new System.Drawing.Point(594, 287);
            this.maskedTextBoxRg.Mask = "9.999.999";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(310, 23);
            this.maskedTextBoxRg.TabIndex = 18;
            // 
            // comboBoxEndereco
            // 
            this.comboBoxEndereco.FormattingEnabled = true;
            this.comboBoxEndereco.Location = new System.Drawing.Point(594, 149);
            this.comboBoxEndereco.Name = "comboBoxEndereco";
            this.comboBoxEndereco.Size = new System.Drawing.Size(310, 23);
            this.comboBoxEndereco.TabIndex = 19;
            // 
            // checkBoxCarro
            // 
            this.checkBoxCarro.AutoSize = true;
            this.checkBoxCarro.Location = new System.Drawing.Point(595, 338);
            this.checkBoxCarro.Name = "checkBoxCarro";
            this.checkBoxCarro.Size = new System.Drawing.Size(55, 19);
            this.checkBoxCarro.TabIndex = 20;
            this.checkBoxCarro.Text = "Carro";
            this.checkBoxCarro.UseVisualStyleBackColor = true;
            // 
            // checkBoxMoto
            // 
            this.checkBoxMoto.AutoSize = true;
            this.checkBoxMoto.Location = new System.Drawing.Point(595, 363);
            this.checkBoxMoto.Name = "checkBoxMoto";
            this.checkBoxMoto.Size = new System.Drawing.Size(55, 19);
            this.checkBoxMoto.TabIndex = 21;
            this.checkBoxMoto.Text = "Moto";
            this.checkBoxMoto.UseVisualStyleBackColor = true;
            // 
            // labelPossuiVeiculo
            // 
            this.labelPossuiVeiculo.AutoSize = true;
            this.labelPossuiVeiculo.Location = new System.Drawing.Point(594, 320);
            this.labelPossuiVeiculo.Name = "labelPossuiVeiculo";
            this.labelPossuiVeiculo.Size = new System.Drawing.Size(82, 15);
            this.labelPossuiVeiculo.TabIndex = 22;
            this.labelPossuiVeiculo.Text = "Possui veículo";
            // 
            // PessoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 406);
            this.Controls.Add(this.labelPossuiVeiculo);
            this.Controls.Add(this.checkBoxMoto);
            this.Controls.Add(this.checkBoxCarro);
            this.Controls.Add(this.comboBoxEndereco);
            this.Controls.Add(this.maskedTextBoxRg);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelRg);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PessoaForm";
            this.Text = "PessoaForm";
            this.Load += new System.EventHandler(this.PessoaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonEditar;
        private Label labelNome;
        private Label labelDataNascimento;
        private Label labelEndereco;
        private Label labelSexo;
        private Label labelCpf;
        private Label labelRg;
        private TextBox textBoxNome;
        private DateTimePicker dateTimePickerDataNascimento;
        private ComboBox comboBoxSexo;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxRg;
        private ComboBox comboBoxEndereco;
        private CheckBox checkBoxCarro;
        private CheckBox checkBoxMoto;
        private Label labelPossuiVeiculo;
    }
}