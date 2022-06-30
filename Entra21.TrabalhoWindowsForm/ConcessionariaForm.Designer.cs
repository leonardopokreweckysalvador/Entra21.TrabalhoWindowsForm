namespace Entra21.TrabalhoWindowsForm
{
    partial class ConcessionariaForm
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
            this.dataGridViewConcessionaria = new System.Windows.Forms.DataGridView();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.labelRazaoSocial = new System.Windows.Forms.Label();
            this.textBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.comboBoxProprietario = new System.Windows.Forms.ComboBox();
            this.labelProprietario = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.comboBoxEndereco = new System.Windows.Forms.ComboBox();
            this.labelDataAbertura = new System.Windows.Forms.Label();
            this.dateTimePickerDataAbertura = new System.Windows.Forms.DateTimePicker();
            this.labelHoraAbre = new System.Windows.Forms.Label();
            this.labelHoraFecha = new System.Windows.Forms.Label();
            this.dateTimePickerHoraAbre = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraFecha = new System.Windows.Forms.DateTimePicker();
            this.radioButtonAbreFinalSemana = new System.Windows.Forms.RadioButton();
            this.radioButtonNaoAbreFinalSemana = new System.Windows.Forms.RadioButton();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.checkBoxApertoFinalSemana = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcessionaria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConcessionaria
            // 
            this.dataGridViewConcessionaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcessionaria.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewConcessionaria.Name = "dataGridViewConcessionaria";
            this.dataGridViewConcessionaria.RowTemplate.Height = 25;
            this.dataGridViewConcessionaria.Size = new System.Drawing.Size(571, 373);
            this.dataGridViewConcessionaria.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(607, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(607, 36);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(341, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(607, 64);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(34, 15);
            this.labelCnpj.TabIndex = 3;
            this.labelCnpj.Text = "CNPJ";
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(607, 81);
            this.maskedTextBoxCnpj.Mask = "99.999.999/9999-99";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(341, 23);
            this.maskedTextBoxCnpj.TabIndex = 4;
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.Location = new System.Drawing.Point(607, 116);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(72, 15);
            this.labelRazaoSocial.TabIndex = 5;
            this.labelRazaoSocial.Text = "Razão Social";
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(607, 134);
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(341, 23);
            this.textBoxRazaoSocial.TabIndex = 6;
            // 
            // comboBoxProprietario
            // 
            this.comboBoxProprietario.FormattingEnabled = true;
            this.comboBoxProprietario.Location = new System.Drawing.Point(607, 185);
            this.comboBoxProprietario.Name = "comboBoxProprietario";
            this.comboBoxProprietario.Size = new System.Drawing.Size(341, 23);
            this.comboBoxProprietario.TabIndex = 7;
            // 
            // labelProprietario
            // 
            this.labelProprietario.AutoSize = true;
            this.labelProprietario.Location = new System.Drawing.Point(607, 167);
            this.labelProprietario.Name = "labelProprietario";
            this.labelProprietario.Size = new System.Drawing.Size(69, 15);
            this.labelProprietario.TabIndex = 8;
            this.labelProprietario.Text = "Proprietário";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(607, 218);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 15);
            this.labelEndereco.TabIndex = 9;
            this.labelEndereco.Text = "Endereço";
            // 
            // comboBoxEndereco
            // 
            this.comboBoxEndereco.FormattingEnabled = true;
            this.comboBoxEndereco.Location = new System.Drawing.Point(607, 236);
            this.comboBoxEndereco.Name = "comboBoxEndereco";
            this.comboBoxEndereco.Size = new System.Drawing.Size(341, 23);
            this.comboBoxEndereco.TabIndex = 10;
            // 
            // labelDataAbertura
            // 
            this.labelDataAbertura.AutoSize = true;
            this.labelDataAbertura.Location = new System.Drawing.Point(607, 267);
            this.labelDataAbertura.Name = "labelDataAbertura";
            this.labelDataAbertura.Size = new System.Drawing.Size(80, 15);
            this.labelDataAbertura.TabIndex = 11;
            this.labelDataAbertura.Text = "Data Abertura";
            // 
            // dateTimePickerDataAbertura
            // 
            this.dateTimePickerDataAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataAbertura.Location = new System.Drawing.Point(607, 285);
            this.dateTimePickerDataAbertura.Name = "dateTimePickerDataAbertura";
            this.dateTimePickerDataAbertura.Size = new System.Drawing.Size(249, 23);
            this.dateTimePickerDataAbertura.TabIndex = 12;
            this.dateTimePickerDataAbertura.Value = new System.DateTime(2022, 6, 26, 18, 52, 19, 0);
            // 
            // labelHoraAbre
            // 
            this.labelHoraAbre.AutoSize = true;
            this.labelHoraAbre.Location = new System.Drawing.Point(607, 317);
            this.labelHoraAbre.Name = "labelHoraAbre";
            this.labelHoraAbre.Size = new System.Drawing.Size(61, 15);
            this.labelHoraAbre.TabIndex = 13;
            this.labelHoraAbre.Text = "Hora Abre";
            // 
            // labelHoraFecha
            // 
            this.labelHoraFecha.AutoSize = true;
            this.labelHoraFecha.Location = new System.Drawing.Point(781, 317);
            this.labelHoraFecha.Name = "labelHoraFecha";
            this.labelHoraFecha.Size = new System.Drawing.Size(67, 15);
            this.labelHoraFecha.TabIndex = 14;
            this.labelHoraFecha.Text = "Hora Fecha";
            // 
            // dateTimePickerHoraAbre
            // 
            this.dateTimePickerHoraAbre.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraAbre.Location = new System.Drawing.Point(608, 335);
            this.dateTimePickerHoraAbre.Name = "dateTimePickerHoraAbre";
            this.dateTimePickerHoraAbre.Size = new System.Drawing.Size(167, 23);
            this.dateTimePickerHoraAbre.TabIndex = 15;
            // 
            // dateTimePickerHoraFecha
            // 
            this.dateTimePickerHoraFecha.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFecha.Location = new System.Drawing.Point(781, 335);
            this.dateTimePickerHoraFecha.Name = "dateTimePickerHoraFecha";
            this.dateTimePickerHoraFecha.Size = new System.Drawing.Size(167, 23);
            this.dateTimePickerHoraFecha.TabIndex = 16;
            // 
            // radioButtonAbreFinalSemana
            // 
            this.radioButtonAbreFinalSemana.AutoSize = true;
            this.radioButtonAbreFinalSemana.Checked = true;
            this.radioButtonAbreFinalSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAbreFinalSemana.Location = new System.Drawing.Point(607, 364);
            this.radioButtonAbreFinalSemana.Name = "radioButtonAbreFinalSemana";
            this.radioButtonAbreFinalSemana.Size = new System.Drawing.Size(141, 22);
            this.radioButtonAbreFinalSemana.TabIndex = 17;
            this.radioButtonAbreFinalSemana.TabStop = true;
            this.radioButtonAbreFinalSemana.Text = "Abre Final de Semana";
            this.radioButtonAbreFinalSemana.UseCompatibleTextRendering = true;
            this.radioButtonAbreFinalSemana.UseVisualStyleBackColor = true;
            // 
            // radioButtonNaoAbreFinalSemana
            // 
            this.radioButtonNaoAbreFinalSemana.AutoSize = true;
            this.radioButtonNaoAbreFinalSemana.Location = new System.Drawing.Point(781, 364);
            this.radioButtonNaoAbreFinalSemana.Name = "radioButtonNaoAbreFinalSemana";
            this.radioButtonNaoAbreFinalSemana.Size = new System.Drawing.Size(162, 19);
            this.radioButtonNaoAbreFinalSemana.TabIndex = 18;
            this.radioButtonNaoAbreFinalSemana.Text = "Não Abre final de Semana";
            this.radioButtonNaoAbreFinalSemana.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(608, 426);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(138, 23);
            this.buttonSalvar.TabIndex = 19;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(809, 426);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(139, 23);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 7);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 21;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(93, 7);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 22;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // checkBoxApertoFinalSemana
            // 
            this.checkBoxApertoFinalSemana.AutoSize = true;
            this.checkBoxApertoFinalSemana.Location = new System.Drawing.Point(345, 426);
            this.checkBoxApertoFinalSemana.Name = "checkBoxApertoFinalSemana";
            this.checkBoxApertoFinalSemana.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxApertoFinalSemana.Size = new System.Drawing.Size(238, 19);
            this.checkBoxApertoFinalSemana.TabIndex = 23;
            this.checkBoxApertoFinalSemana.Text = "Concessionarias abertas final de semana";
            this.checkBoxApertoFinalSemana.UseVisualStyleBackColor = true;
            // 
            // ConcessionariaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.checkBoxApertoFinalSemana);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.radioButtonNaoAbreFinalSemana);
            this.Controls.Add(this.radioButtonAbreFinalSemana);
            this.Controls.Add(this.dateTimePickerHoraFecha);
            this.Controls.Add(this.dateTimePickerHoraAbre);
            this.Controls.Add(this.labelHoraFecha);
            this.Controls.Add(this.labelHoraAbre);
            this.Controls.Add(this.dateTimePickerDataAbertura);
            this.Controls.Add(this.labelDataAbertura);
            this.Controls.Add(this.comboBoxEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelProprietario);
            this.Controls.Add(this.comboBoxProprietario);
            this.Controls.Add(this.textBoxRazaoSocial);
            this.Controls.Add(this.labelRazaoSocial);
            this.Controls.Add(this.maskedTextBoxCnpj);
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dataGridViewConcessionaria);
            this.Name = "ConcessionariaForm";
            this.Text = "Concessionaria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcessionaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewConcessionaria;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelCnpj;
        private MaskedTextBox maskedTextBoxCnpj;
        private Label labelRazaoSocial;
        private TextBox textBoxRazaoSocial;
        private ComboBox comboBoxProprietario;
        private Label labelProprietario;
        private Label labelEndereco;
        private ComboBox comboBoxEndereco;
        private Label labelDataAbertura;
        private DateTimePicker dateTimePickerDataAbertura;
        private Label labelHoraAbre;
        private Label labelHoraFecha;
        private DateTimePicker dateTimePickerHoraAbre;
        private DateTimePicker dateTimePickerHoraFecha;
        private RadioButton radioButtonAbreFinalSemana;
        private RadioButton radioButtonNaoAbreFinalSemana;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private Button buttonEditar;
        private Button buttonApagar;
        private CheckBox checkBoxApertoFinalSemana;
    }
}