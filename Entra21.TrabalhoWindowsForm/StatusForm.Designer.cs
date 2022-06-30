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
            this.radioButtonNomeLimpo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonNomeLimpo2 = new System.Windows.Forms.RadioButton();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.comboBoxEndereco = new System.Windows.Forms.ComboBox();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.textBoxLimiteFinanceiro = new System.Windows.Forms.TextBox();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpresaTrabalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeLimpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLimiteFinanceiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnDataCadastro,
            this.ColumnPessoa,
            this.ColumnProfissão,
            this.ColumnEmpresaTrabalho,
            this.ColumnSalario,
            this.ColumnNomeLimpo,
            this.ColumnLimiteFinanceiro});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(858, 10);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(776, 10);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(1119, 415);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1200, 415);
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
            this.labelDataCadastro.Location = new System.Drawing.Point(946, 45);
            this.labelDataCadastro.Name = "labelDataCadastro";
            this.labelDataCadastro.Size = new System.Drawing.Size(98, 15);
            this.labelDataCadastro.TabIndex = 5;
            this.labelDataCadastro.Text = "Data do Cadastro";
            // 
            // labelPessoa
            // 
            this.labelPessoa.AutoSize = true;
            this.labelPessoa.Location = new System.Drawing.Point(946, 95);
            this.labelPessoa.Name = "labelPessoa";
            this.labelPessoa.Size = new System.Drawing.Size(94, 15);
            this.labelPessoa.TabIndex = 6;
            this.labelPessoa.Text = "Nome completo";
            // 
            // labelProfissao
            // 
            this.labelProfissao.AutoSize = true;
            this.labelProfissao.Location = new System.Drawing.Point(946, 182);
            this.labelProfissao.Name = "labelProfissao";
            this.labelProfissao.Size = new System.Drawing.Size(55, 15);
            this.labelProfissao.TabIndex = 7;
            this.labelProfissao.Text = "Profissão";
            // 
            // labelEmpresaTrabalho
            // 
            this.labelEmpresaTrabalho.AutoSize = true;
            this.labelEmpresaTrabalho.Location = new System.Drawing.Point(946, 233);
            this.labelEmpresaTrabalho.Name = "labelEmpresaTrabalho";
            this.labelEmpresaTrabalho.Size = new System.Drawing.Size(107, 15);
            this.labelEmpresaTrabalho.TabIndex = 8;
            this.labelEmpresaTrabalho.Text = "Empresa (trabalho)";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(946, 284);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(42, 15);
            this.labelSalario.TabIndex = 9;
            this.labelSalario.Text = "Salário";
            // 
            // labelNomeLimpo
            // 
            this.labelNomeLimpo.AutoSize = true;
            this.labelNomeLimpo.Location = new System.Drawing.Point(946, 327);
            this.labelNomeLimpo.Name = "labelNomeLimpo";
            this.labelNomeLimpo.Size = new System.Drawing.Size(83, 15);
            this.labelNomeLimpo.TabIndex = 10;
            this.labelNomeLimpo.Text = "Nome é limpo";
            // 
            // labelLimiteFinanceiro
            // 
            this.labelLimiteFinanceiro.AutoSize = true;
            this.labelLimiteFinanceiro.Location = new System.Drawing.Point(946, 368);
            this.labelLimiteFinanceiro.Name = "labelLimiteFinanceiro";
            this.labelLimiteFinanceiro.Size = new System.Drawing.Size(98, 15);
            this.labelLimiteFinanceiro.TabIndex = 11;
            this.labelLimiteFinanceiro.Text = "Limite Financeiro";
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(946, 63);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(329, 23);
            this.dateTimePickerDataCadastro.TabIndex = 12;
            // 
            // comboBoxNomeCompleto
            // 
            this.comboBoxNomeCompleto.FormattingEnabled = true;
            this.comboBoxNomeCompleto.Location = new System.Drawing.Point(946, 113);
            this.comboBoxNomeCompleto.Name = "comboBoxNomeCompleto";
            this.comboBoxNomeCompleto.Size = new System.Drawing.Size(329, 23);
            this.comboBoxNomeCompleto.TabIndex = 13;
            // 
            // textBoxProfissao
            // 
            this.textBoxProfissao.Location = new System.Drawing.Point(946, 200);
            this.textBoxProfissao.Name = "textBoxProfissao";
            this.textBoxProfissao.Size = new System.Drawing.Size(329, 23);
            this.textBoxProfissao.TabIndex = 14;
            // 
            // textBoxEmpresaTrabalho
            // 
            this.textBoxEmpresaTrabalho.Location = new System.Drawing.Point(946, 251);
            this.textBoxEmpresaTrabalho.Name = "textBoxEmpresaTrabalho";
            this.textBoxEmpresaTrabalho.Size = new System.Drawing.Size(329, 23);
            this.textBoxEmpresaTrabalho.TabIndex = 15;
            // 
            // radioButtonNomeLimpo1
            // 
            this.radioButtonNomeLimpo1.AutoSize = true;
            this.radioButtonNomeLimpo1.Location = new System.Drawing.Point(946, 345);
            this.radioButtonNomeLimpo1.Name = "radioButtonNomeLimpo1";
            this.radioButtonNomeLimpo1.Size = new System.Drawing.Size(45, 19);
            this.radioButtonNomeLimpo1.TabIndex = 17;
            this.radioButtonNomeLimpo1.TabStop = true;
            this.radioButtonNomeLimpo1.Text = "Sim";
            this.radioButtonNomeLimpo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonNomeLimpo2
            // 
            this.radioButtonNomeLimpo2.AutoSize = true;
            this.radioButtonNomeLimpo2.Location = new System.Drawing.Point(1007, 345);
            this.radioButtonNomeLimpo2.Name = "radioButtonNomeLimpo2";
            this.radioButtonNomeLimpo2.Size = new System.Drawing.Size(47, 19);
            this.radioButtonNomeLimpo2.TabIndex = 19;
            this.radioButtonNomeLimpo2.TabStop = true;
            this.radioButtonNomeLimpo2.Text = "Não";
            this.radioButtonNomeLimpo2.UseVisualStyleBackColor = true;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(946, 139);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelEndereco.Size = new System.Drawing.Size(56, 15);
            this.labelEndereco.TabIndex = 20;
            this.labelEndereco.Text = "Endereço";
            // 
            // comboBoxEndereco
            // 
            this.comboBoxEndereco.FormattingEnabled = true;
            this.comboBoxEndereco.Location = new System.Drawing.Point(947, 156);
            this.comboBoxEndereco.Name = "comboBoxEndereco";
            this.comboBoxEndereco.Size = new System.Drawing.Size(328, 23);
            this.comboBoxEndereco.TabIndex = 21;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(947, 302);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(328, 23);
            this.textBoxSalario.TabIndex = 22;
            // 
            // textBoxLimiteFinanceiro
            // 
            this.textBoxLimiteFinanceiro.Location = new System.Drawing.Point(947, 386);
            this.textBoxLimiteFinanceiro.Name = "textBoxLimiteFinanceiro";
            this.textBoxLimiteFinanceiro.Size = new System.Drawing.Size(328, 23);
            this.textBoxLimiteFinanceiro.TabIndex = 23;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnDataCadastro
            // 
            this.ColumnDataCadastro.HeaderText = "Data do Cadastro";
            this.ColumnDataCadastro.MinimumWidth = 6;
            this.ColumnDataCadastro.Name = "ColumnDataCadastro";
            this.ColumnDataCadastro.ReadOnly = true;
            this.ColumnDataCadastro.Width = 125;
            // 
            // ColumnPessoa
            // 
            this.ColumnPessoa.HeaderText = "Pessoa";
            this.ColumnPessoa.MinimumWidth = 6;
            this.ColumnPessoa.Name = "ColumnPessoa";
            this.ColumnPessoa.ReadOnly = true;
            this.ColumnPessoa.Width = 125;
            // 
            // ColumnProfissão
            // 
            this.ColumnProfissão.HeaderText = "Profissão";
            this.ColumnProfissão.MinimumWidth = 6;
            this.ColumnProfissão.Name = "ColumnProfissão";
            this.ColumnProfissão.ReadOnly = true;
            this.ColumnProfissão.Width = 125;
            // 
            // ColumnEmpresaTrabalho
            // 
            this.ColumnEmpresaTrabalho.HeaderText = "Empresa (trabalho)";
            this.ColumnEmpresaTrabalho.MinimumWidth = 6;
            this.ColumnEmpresaTrabalho.Name = "ColumnEmpresaTrabalho";
            this.ColumnEmpresaTrabalho.ReadOnly = true;
            this.ColumnEmpresaTrabalho.Width = 125;
            // 
            // ColumnSalario
            // 
            this.ColumnSalario.HeaderText = "Salário";
            this.ColumnSalario.MinimumWidth = 6;
            this.ColumnSalario.Name = "ColumnSalario";
            this.ColumnSalario.ReadOnly = true;
            this.ColumnSalario.Width = 125;
            // 
            // ColumnNomeLimpo
            // 
            this.ColumnNomeLimpo.HeaderText = "Nome é Limpo";
            this.ColumnNomeLimpo.MinimumWidth = 6;
            this.ColumnNomeLimpo.Name = "ColumnNomeLimpo";
            this.ColumnNomeLimpo.ReadOnly = true;
            this.ColumnNomeLimpo.Width = 125;
            // 
            // ColumnLimiteFinanceiro
            // 
            this.ColumnLimiteFinanceiro.HeaderText = "Limite Financeiro";
            this.ColumnLimiteFinanceiro.MinimumWidth = 6;
            this.ColumnLimiteFinanceiro.Name = "ColumnLimiteFinanceiro";
            this.ColumnLimiteFinanceiro.ReadOnly = true;
            this.ColumnLimiteFinanceiro.Width = 125;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 450);
            this.Controls.Add(this.textBoxLimiteFinanceiro);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.comboBoxEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.radioButtonNomeLimpo2);
            this.Controls.Add(this.radioButtonNomeLimpo1);
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
            this.Load += new System.EventHandler(this.StatusForm_Load);
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
        private RadioButton radioButtonNomeLimpo1;
        private RadioButton radioButtonNomeLimpo2;
        private Label labelEndereco;
        private ComboBox comboBoxEndereco;
        private TextBox textBoxSalario;
        private TextBox textBoxLimiteFinanceiro;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnDataCadastro;
        private DataGridViewTextBoxColumn ColumnPessoa;
        private DataGridViewTextBoxColumn ColumnProfissão;
        private DataGridViewTextBoxColumn ColumnEmpresaTrabalho;
        private DataGridViewTextBoxColumn ColumnSalario;
        private DataGridViewTextBoxColumn ColumnNomeLimpo;
        private DataGridViewTextBoxColumn ColumnLimiteFinanceiro;
    }
}