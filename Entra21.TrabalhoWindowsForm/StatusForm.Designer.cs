namespace Entra21.TrabalhoWindowsForm
{
    partial class StatusForm
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelDataCadastro = new System.Windows.Forms.Label();
            this.labelPessoa = new System.Windows.Forms.Label();
            this.labelProfissao = new System.Windows.Forms.Label();
            this.labelEmpresaTrabalho = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelNomeLimpo = new System.Windows.Forms.Label();
            this.labelLimiteFinanceiro = new System.Windows.Forms.Label();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNomeCompleto = new System.Windows.Forms.ComboBox();
            this.textBoxProfissao = new System.Windows.Forms.TextBox();
            this.textBoxEmpresaTrabalho = new System.Windows.Forms.TextBox();
            this.maskedTextBoxSalario = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonNomeLimpo1 = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxLimiteFinanceiro = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonNomeLimpo2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(515, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(434, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(784, 415);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(865, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelDataCadastro
            // 
            this.labelDataCadastro.AutoSize = true;
            this.labelDataCadastro.Location = new System.Drawing.Point(611, 45);
            this.labelDataCadastro.Name = "labelDataCadastro";
            this.labelDataCadastro.Size = new System.Drawing.Size(101, 15);
            this.labelDataCadastro.TabIndex = 5;
            this.labelDataCadastro.Text = "Data do Cadastro";
            // 
            // labelPessoa
            // 
            this.labelPessoa.AutoSize = true;
            this.labelPessoa.Location = new System.Drawing.Point(611, 95);
            this.labelPessoa.Name = "labelPessoa";
            this.labelPessoa.Size = new System.Drawing.Size(88, 15);
            this.labelPessoa.TabIndex = 6;
            this.labelPessoa.Text = "Nome completo";
            // 
            // labelProfissao
            // 
            this.labelProfissao.AutoSize = true;
            this.labelProfissao.Location = new System.Drawing.Point(611, 145);
            this.labelProfissao.Name = "labelProfissao";
            this.labelProfissao.Size = new System.Drawing.Size(54, 15);
            this.labelProfissao.TabIndex = 7;
            this.labelProfissao.Text = "Profissão";
            // 
            // labelEmpresaTrabalho
            // 
            this.labelEmpresaTrabalho.AutoSize = true;
            this.labelEmpresaTrabalho.Location = new System.Drawing.Point(611, 196);
            this.labelEmpresaTrabalho.Name = "labelEmpresaTrabalho";
            this.labelEmpresaTrabalho.Size = new System.Drawing.Size(108, 15);
            this.labelEmpresaTrabalho.TabIndex = 8;
            this.labelEmpresaTrabalho.Text = "Empresa (trabalho)";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(611, 247);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(43, 15);
            this.labelSalario.TabIndex = 9;
            this.labelSalario.Text = "Salário";
            this.labelSalario.Click += new System.EventHandler(this.labelSalario_Click);
            // 
            // labelNomeLimpo
            // 
            this.labelNomeLimpo.AutoSize = true;
            this.labelNomeLimpo.Location = new System.Drawing.Point(611, 298);
            this.labelNomeLimpo.Name = "labelNomeLimpo";
            this.labelNomeLimpo.Size = new System.Drawing.Size(79, 15);
            this.labelNomeLimpo.TabIndex = 10;
            this.labelNomeLimpo.Text = "Nome é limpo";
            // 
            // labelLimiteFinanceiro
            // 
            this.labelLimiteFinanceiro.AutoSize = true;
            this.labelLimiteFinanceiro.Location = new System.Drawing.Point(611, 339);
            this.labelLimiteFinanceiro.Name = "labelLimiteFinanceiro";
            this.labelLimiteFinanceiro.Size = new System.Drawing.Size(96, 15);
            this.labelLimiteFinanceiro.TabIndex = 11;
            this.labelLimiteFinanceiro.Text = "Limite Financeiro";
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(611, 63);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(329, 23);
            this.dateTimePickerDataCadastro.TabIndex = 12;
            // 
            // comboBoxNomeCompleto
            // 
            this.comboBoxNomeCompleto.FormattingEnabled = true;
            this.comboBoxNomeCompleto.Location = new System.Drawing.Point(611, 113);
            this.comboBoxNomeCompleto.Name = "comboBoxNomeCompleto";
            this.comboBoxNomeCompleto.Size = new System.Drawing.Size(329, 23);
            this.comboBoxNomeCompleto.TabIndex = 13;
            // 
            // textBoxProfissao
            // 
            this.textBoxProfissao.Location = new System.Drawing.Point(611, 163);
            this.textBoxProfissao.Name = "textBoxProfissao";
            this.textBoxProfissao.Size = new System.Drawing.Size(329, 23);
            this.textBoxProfissao.TabIndex = 14;
            // 
            // textBoxEmpresaTrabalho
            // 
            this.textBoxEmpresaTrabalho.Location = new System.Drawing.Point(611, 214);
            this.textBoxEmpresaTrabalho.Name = "textBoxEmpresaTrabalho";
            this.textBoxEmpresaTrabalho.Size = new System.Drawing.Size(329, 23);
            this.textBoxEmpresaTrabalho.TabIndex = 15;
            // 
            // maskedTextBoxSalario
            // 
            this.maskedTextBoxSalario.Location = new System.Drawing.Point(611, 265);
            this.maskedTextBoxSalario.Mask = "R$";
            this.maskedTextBoxSalario.Name = "maskedTextBoxSalario";
            this.maskedTextBoxSalario.Size = new System.Drawing.Size(329, 23);
            this.maskedTextBoxSalario.TabIndex = 16;
            // 
            // radioButtonNomeLimpo1
            // 
            this.radioButtonNomeLimpo1.AutoSize = true;
            this.radioButtonNomeLimpo1.Location = new System.Drawing.Point(611, 316);
            this.radioButtonNomeLimpo1.Name = "radioButtonNomeLimpo1";
            this.radioButtonNomeLimpo1.Size = new System.Drawing.Size(44, 19);
            this.radioButtonNomeLimpo1.TabIndex = 17;
            this.radioButtonNomeLimpo1.TabStop = true;
            this.radioButtonNomeLimpo1.Text = "Sim";
            this.radioButtonNomeLimpo1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxLimiteFinanceiro
            // 
            this.maskedTextBoxLimiteFinanceiro.Location = new System.Drawing.Point(612, 357);
            this.maskedTextBoxLimiteFinanceiro.Mask = "R$";
            this.maskedTextBoxLimiteFinanceiro.Name = "maskedTextBoxLimiteFinanceiro";
            this.maskedTextBoxLimiteFinanceiro.Size = new System.Drawing.Size(328, 23);
            this.maskedTextBoxLimiteFinanceiro.TabIndex = 18;
            // 
            // radioButtonNomeLimpo2
            // 
            this.radioButtonNomeLimpo2.AutoSize = true;
            this.radioButtonNomeLimpo2.Location = new System.Drawing.Point(672, 316);
            this.radioButtonNomeLimpo2.Name = "radioButtonNomeLimpo2";
            this.radioButtonNomeLimpo2.Size = new System.Drawing.Size(47, 19);
            this.radioButtonNomeLimpo2.TabIndex = 19;
            this.radioButtonNomeLimpo2.TabStop = true;
            this.radioButtonNomeLimpo2.Text = "Não";
            this.radioButtonNomeLimpo2.UseVisualStyleBackColor = true;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.radioButtonNomeLimpo2);
            this.Controls.Add(this.maskedTextBoxLimiteFinanceiro);
            this.Controls.Add(this.radioButtonNomeLimpo1);
            this.Controls.Add(this.maskedTextBoxSalario);
            this.Controls.Add(this.textBoxEmpresaTrabalho);
            this.Controls.Add(this.textBoxProfissao);
            this.Controls.Add(this.comboBoxNomeCompleto);
            this.Controls.Add(this.dateTimePickerDataCadastro);
            this.Controls.Add(this.labelLimiteFinanceiro);
            this.Controls.Add(this.labelNomeLimpo);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelEmpresaTrabalho);
            this.Controls.Add(this.labelProfissao);
            this.Controls.Add(this.labelPessoa);
            this.Controls.Add(this.labelDataCadastro);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StatusForm";
            this.Text = "StatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label labelDataCadastro;
        private Label labelPessoa;
        private Label labelProfissao;
        private Label labelEmpresaTrabalho;
        private Label labelSalario;
        private Label labelNomeLimpo;
        private Label labelLimiteFinanceiro;
        private DateTimePicker dateTimePickerDataCadastro;
        private ComboBox comboBoxNomeCompleto;
        private TextBox textBoxProfissao;
        private TextBox textBoxEmpresaTrabalho;
        private MaskedTextBox maskedTextBoxSalario;
        private RadioButton radioButtonNomeLimpo1;
        private MaskedTextBox maskedTextBoxLimiteFinanceiro;
        private RadioButton radioButtonNomeLimpo2;
    }
}