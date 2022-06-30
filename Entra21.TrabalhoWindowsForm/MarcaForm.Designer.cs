﻿namespace Entra21.TrabalhoWindowsForm
{
    partial class MarcaForm
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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.ColumnNomeMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrupoProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaisDeOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataDeFundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPossuiManutecaoNacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNomeMarca = new System.Windows.Forms.Label();
            this.labelGrupoProprietarioMarca = new System.Windows.Forms.Label();
            this.labelPaisOrigemMarca = new System.Windows.Forms.Label();
            this.labelAnoFundacaoMarca = new System.Windows.Forms.Label();
            this.labelMarcaNacionalOuImportada = new System.Windows.Forms.Label();
            this.textBoxNomeMarca = new System.Windows.Forms.TextBox();
            this.textBoxGrupoProprietarioMarca = new System.Windows.Forms.TextBox();
            this.textBoxPaisDeOrigem = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataDeFundacaoMarca = new System.Windows.Forms.DateTimePicker();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(112, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(1360, 418);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1460, 418);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.AllowUserToAddRows = false;
            this.dataGridViewMarca.AllowUserToDeleteRows = false;
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeMarca,
            this.ColumnGrupoProprietario,
            this.ColumnPaisDeOrigem,
            this.ColumnDataDeFundacao,
            this.ColumnPossuiManutecaoNacional});
            this.dataGridViewMarca.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.ReadOnly = true;
            this.dataGridViewMarca.RowHeadersWidth = 51;
            this.dataGridViewMarca.RowTemplate.Height = 29;
            this.dataGridViewMarca.Size = new System.Drawing.Size(1178, 398);
            this.dataGridViewMarca.TabIndex = 4;
            // 
            // ColumnNomeMarca
            // 
            this.ColumnNomeMarca.HeaderText = "Marca";
            this.ColumnNomeMarca.MinimumWidth = 6;
            this.ColumnNomeMarca.Name = "ColumnNomeMarca";
            this.ColumnNomeMarca.ReadOnly = true;
            this.ColumnNomeMarca.Width = 125;
            // 
            // ColumnGrupoProprietario
            // 
            this.ColumnGrupoProprietario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnGrupoProprietario.HeaderText = "Grupo Proprietário da Marca";
            this.ColumnGrupoProprietario.MinimumWidth = 6;
            this.ColumnGrupoProprietario.Name = "ColumnGrupoProprietario";
            this.ColumnGrupoProprietario.ReadOnly = true;
            this.ColumnGrupoProprietario.Width = 250;
            // 
            // ColumnPaisDeOrigem
            // 
            this.ColumnPaisDeOrigem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPaisDeOrigem.HeaderText = "País de Origem da Marca";
            this.ColumnPaisDeOrigem.MinimumWidth = 6;
            this.ColumnPaisDeOrigem.Name = "ColumnPaisDeOrigem";
            this.ColumnPaisDeOrigem.ReadOnly = true;
            this.ColumnPaisDeOrigem.Width = 250;
            // 
            // ColumnDataDeFundacao
            // 
            this.ColumnDataDeFundacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDataDeFundacao.HeaderText = "Data de Fundação da Marca";
            this.ColumnDataDeFundacao.MinimumWidth = 6;
            this.ColumnDataDeFundacao.Name = "ColumnDataDeFundacao";
            this.ColumnDataDeFundacao.ReadOnly = true;
            this.ColumnDataDeFundacao.Width = 250;
            // 
            // ColumnPossuiManutecaoNacional
            // 
            this.ColumnPossuiManutecaoNacional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPossuiManutecaoNacional.HeaderText = "Possui Manutenção Nacional?";
            this.ColumnPossuiManutecaoNacional.MinimumWidth = 6;
            this.ColumnPossuiManutecaoNacional.Name = "ColumnPossuiManutecaoNacional";
            this.ColumnPossuiManutecaoNacional.ReadOnly = true;
            this.ColumnPossuiManutecaoNacional.Width = 250;
            // 
            // labelNomeMarca
            // 
            this.labelNomeMarca.AutoSize = true;
            this.labelNomeMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomeMarca.Location = new System.Drawing.Point(1196, 37);
            this.labelNomeMarca.Name = "labelNomeMarca";
            this.labelNomeMarca.Size = new System.Drawing.Size(120, 20);
            this.labelNomeMarca.TabIndex = 5;
            this.labelNomeMarca.Text = "Nome da marca";
            // 
            // labelGrupoProprietarioMarca
            // 
            this.labelGrupoProprietarioMarca.AutoSize = true;
            this.labelGrupoProprietarioMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGrupoProprietarioMarca.Location = new System.Drawing.Point(1196, 90);
            this.labelGrupoProprietarioMarca.Name = "labelGrupoProprietarioMarca";
            this.labelGrupoProprietarioMarca.Size = new System.Drawing.Size(209, 20);
            this.labelGrupoProprietarioMarca.TabIndex = 6;
            this.labelGrupoProprietarioMarca.Text = "Grupo Proprietário da marca";
            // 
            // labelPaisOrigemMarca
            // 
            this.labelPaisOrigemMarca.AutoSize = true;
            this.labelPaisOrigemMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPaisOrigemMarca.Location = new System.Drawing.Point(1196, 143);
            this.labelPaisOrigemMarca.Name = "labelPaisOrigemMarca";
            this.labelPaisOrigemMarca.Size = new System.Drawing.Size(180, 20);
            this.labelPaisOrigemMarca.TabIndex = 7;
            this.labelPaisOrigemMarca.Text = "Pais de origem da marca";
            // 
            // labelAnoFundacaoMarca
            // 
            this.labelAnoFundacaoMarca.AutoSize = true;
            this.labelAnoFundacaoMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAnoFundacaoMarca.Location = new System.Drawing.Point(1196, 196);
            this.labelAnoFundacaoMarca.Name = "labelAnoFundacaoMarca";
            this.labelAnoFundacaoMarca.Size = new System.Drawing.Size(200, 20);
            this.labelAnoFundacaoMarca.TabIndex = 8;
            this.labelAnoFundacaoMarca.Text = "Data de fundação da marca";
            // 
            // labelMarcaNacionalOuImportada
            // 
            this.labelMarcaNacionalOuImportada.AutoSize = true;
            this.labelMarcaNacionalOuImportada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMarcaNacionalOuImportada.Location = new System.Drawing.Point(1196, 249);
            this.labelMarcaNacionalOuImportada.Name = "labelMarcaNacionalOuImportada";
            this.labelMarcaNacionalOuImportada.Size = new System.Drawing.Size(279, 20);
            this.labelMarcaNacionalOuImportada.TabIndex = 9;
            this.labelMarcaNacionalOuImportada.Text = "A marca possui manutenção no Brasil?";
            // 
            // textBoxNomeMarca
            // 
            this.textBoxNomeMarca.Location = new System.Drawing.Point(1196, 60);
            this.textBoxNomeMarca.Name = "textBoxNomeMarca";
            this.textBoxNomeMarca.Size = new System.Drawing.Size(222, 27);
            this.textBoxNomeMarca.TabIndex = 10;
            // 
            // textBoxGrupoProprietarioMarca
            // 
            this.textBoxGrupoProprietarioMarca.Location = new System.Drawing.Point(1196, 113);
            this.textBoxGrupoProprietarioMarca.Name = "textBoxGrupoProprietarioMarca";
            this.textBoxGrupoProprietarioMarca.Size = new System.Drawing.Size(222, 27);
            this.textBoxGrupoProprietarioMarca.TabIndex = 11;
            // 
            // textBoxPaisDeOrigem
            // 
            this.textBoxPaisDeOrigem.Location = new System.Drawing.Point(1196, 166);
            this.textBoxPaisDeOrigem.Name = "textBoxPaisDeOrigem";
            this.textBoxPaisDeOrigem.Size = new System.Drawing.Size(222, 27);
            this.textBoxPaisDeOrigem.TabIndex = 12;
            // 
            // dateTimePickerDataDeFundacaoMarca
            // 
            this.dateTimePickerDataDeFundacaoMarca.Location = new System.Drawing.Point(1196, 219);
            this.dateTimePickerDataDeFundacaoMarca.Name = "dateTimePickerDataDeFundacaoMarca";
            this.dateTimePickerDataDeFundacaoMarca.Size = new System.Drawing.Size(318, 27);
            this.dateTimePickerDataDeFundacaoMarca.TabIndex = 13;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(1196, 272);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(55, 24);
            this.radioButtonSim.TabIndex = 14;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(1319, 272);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(58, 24);
            this.radioButtonNao.TabIndex = 15;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // MarcaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 450);
            this.Controls.Add(this.radioButtonNao);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.dateTimePickerDataDeFundacaoMarca);
            this.Controls.Add(this.textBoxPaisDeOrigem);
            this.Controls.Add(this.textBoxGrupoProprietarioMarca);
            this.Controls.Add(this.textBoxNomeMarca);
            this.Controls.Add(this.labelMarcaNacionalOuImportada);
            this.Controls.Add(this.labelAnoFundacaoMarca);
            this.Controls.Add(this.labelPaisOrigemMarca);
            this.Controls.Add(this.labelGrupoProprietarioMarca);
            this.Controls.Add(this.labelNomeMarca);
            this.Controls.Add(this.dataGridViewMarca);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Name = "MarcaForm";
            this.Text = "MarcaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private DataGridView dataGridViewMarca;
        private Label labelNomeMarca;
        private Label labelGrupoProprietarioMarca;
        private Label labelPaisOrigemMarca;
        private Label labelAnoFundacaoMarca;
        private Label labelMarcaNacionalOuImportada;
        private TextBox textBoxNomeMarca;
        private TextBox textBoxGrupoProprietarioMarca;
        private TextBox textBoxPaisDeOrigem;
        private DateTimePicker dateTimePickerDataDeFundacaoMarca;
        private RadioButton radioButtonSim;
        private RadioButton radioButtonNao;
        private DataGridViewTextBoxColumn ColumnNomeMarca;
        private DataGridViewTextBoxColumn ColumnGrupoProprietario;
        private DataGridViewTextBoxColumn ColumnPaisDeOrigem;
        private DataGridViewTextBoxColumn ColumnDataDeFundacao;
        private DataGridViewTextBoxColumn ColumnPossuiManutecaoNacional;
    }
}