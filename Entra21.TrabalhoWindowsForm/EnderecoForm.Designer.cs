namespace Entra21.TrabalhoWindowsForm
{
    partial class EnderecoForm
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
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewEndereco = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCep = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(602, 37);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(84, 23);
            this.maskedTextBoxCep.TabIndex = 0;
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // dataGridViewEndereco
            // 
            this.dataGridViewEndereco.AllowUserToAddRows = false;
            this.dataGridViewEndereco.AllowUserToDeleteRows = false;
            this.dataGridViewEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cep,
            this.Estado,
            this.Cidade,
            this.Bairro,
            this.Logradouro,
            this.Numero,
            this.Complemento});
            this.dataGridViewEndereco.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewEndereco.Name = "dataGridViewEndereco";
            this.dataGridViewEndereco.ReadOnly = true;
            this.dataGridViewEndereco.RowHeadersWidth = 25;
            this.dataGridViewEndereco.RowTemplate.Height = 25;
            this.dataGridViewEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEndereco.Size = new System.Drawing.Size(570, 373);
            this.dataGridViewEndereco.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 125;
            // 
            // Cep
            // 
            this.Cep.HeaderText = "CEP";
            this.Cep.MinimumWidth = 6;
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.MinimumWidth = 6;
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 125;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.MinimumWidth = 6;
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 125;
            // 
            // Logradouro
            // 
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.MinimumWidth = 6;
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.ReadOnly = true;
            this.Logradouro.Width = 125;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 125;
            // 
            // Complemento
            // 
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.MinimumWidth = 6;
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            this.Complemento.Visible = false;
            this.Complemento.Width = 125;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(602, 19);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(28, 15);
            this.labelCep.TabIndex = 2;
            this.labelCep.Text = "CEP";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(602, 91);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(135, 23);
            this.textBoxEstado.TabIndex = 3;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(602, 141);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(351, 23);
            this.textBoxCidade.TabIndex = 4;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(602, 196);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(351, 23);
            this.textBoxBairro.TabIndex = 5;
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(602, 250);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(246, 23);
            this.textBoxLogradouro.TabIndex = 6;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(854, 250);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(99, 23);
            this.textBoxNumero.TabIndex = 7;
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(602, 303);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(351, 23);
            this.textBoxComplemento.TabIndex = 8;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(602, 73);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(42, 15);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(600, 123);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(44, 15);
            this.labelCidade.TabIndex = 10;
            this.labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(602, 178);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(38, 15);
            this.labelBairro.TabIndex = 11;
            this.labelBairro.Text = "Bairro";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(602, 232);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(69, 15);
            this.labelLogradouro.TabIndex = 12;
            this.labelLogradouro.Text = "Logradouro";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(858, 232);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(51, 15);
            this.labelNumero.TabIndex = 13;
            this.labelNumero.Text = "Número";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(602, 285);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(84, 15);
            this.labelComplemento.TabIndex = 14;
            this.labelComplemento.Text = "Complemento";
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(93, 8);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 15;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 8);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(805, 346);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(148, 23);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(602, 346);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(135, 23);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // EnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 460);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxComplemento);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxLogradouro);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.dataGridViewEndereco);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Name = "EnderecoForm";
            this.Text = "Endereco";
            this.Load += new System.EventHandler(this.EnderecoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox maskedTextBoxCep;
        private DataGridView dataGridViewEndereco;
        private Label labelCep;
        private TextBox textBoxEstado;
        private TextBox textBoxCidade;
        private TextBox textBoxBairro;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private Label labelEstado;
        private Label labelCidade;
        private Label labelBairro;
        private Label labelLogradouro;
        private Label labelNumero;
        private Label labelComplemento;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Cep;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Logradouro;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Complemento;
    }
}