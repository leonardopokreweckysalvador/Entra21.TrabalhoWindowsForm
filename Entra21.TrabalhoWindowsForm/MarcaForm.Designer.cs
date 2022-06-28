namespace Entra21.TrabalhoWindowsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNomeMarca = new System.Windows.Forms.Label();
            this.labelGrupoProprietarioMarca = new System.Windows.Forms.Label();
            this.labelPaisOrigemMarca = new System.Windows.Forms.Label();
            this.labelAnoFundacaoMarca = new System.Windows.Forms.Label();
            this.labelMarcaNacionalOuImportada = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataDeFundacaoMarca = new System.Windows.Forms.DateTimePicker();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.buttonSalvar.Location = new System.Drawing.Point(603, 418);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(703, 418);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(421, 398);
            this.dataGridView1.TabIndex = 4;
            // 
            // labelNomeMarca
            // 
            this.labelNomeMarca.AutoSize = true;
            this.labelNomeMarca.Location = new System.Drawing.Point(439, 37);
            this.labelNomeMarca.Name = "labelNomeMarca";
            this.labelNomeMarca.Size = new System.Drawing.Size(116, 20);
            this.labelNomeMarca.TabIndex = 5;
            this.labelNomeMarca.Text = "Nome da marca";
            // 
            // labelGrupoProprietarioMarca
            // 
            this.labelGrupoProprietarioMarca.AutoSize = true;
            this.labelGrupoProprietarioMarca.Location = new System.Drawing.Point(439, 90);
            this.labelGrupoProprietarioMarca.Name = "labelGrupoProprietarioMarca";
            this.labelGrupoProprietarioMarca.Size = new System.Drawing.Size(199, 20);
            this.labelGrupoProprietarioMarca.TabIndex = 6;
            this.labelGrupoProprietarioMarca.Text = "Grupo Proprietário da marca";
            // 
            // labelPaisOrigemMarca
            // 
            this.labelPaisOrigemMarca.AutoSize = true;
            this.labelPaisOrigemMarca.Location = new System.Drawing.Point(439, 143);
            this.labelPaisOrigemMarca.Name = "labelPaisOrigemMarca";
            this.labelPaisOrigemMarca.Size = new System.Drawing.Size(173, 20);
            this.labelPaisOrigemMarca.TabIndex = 7;
            this.labelPaisOrigemMarca.Text = "Pais de origem da marca";
            // 
            // labelAnoFundacaoMarca
            // 
            this.labelAnoFundacaoMarca.AutoSize = true;
            this.labelAnoFundacaoMarca.Location = new System.Drawing.Point(439, 196);
            this.labelAnoFundacaoMarca.Name = "labelAnoFundacaoMarca";
            this.labelAnoFundacaoMarca.Size = new System.Drawing.Size(194, 20);
            this.labelAnoFundacaoMarca.TabIndex = 8;
            this.labelAnoFundacaoMarca.Text = "Data de fundação da marca";
            // 
            // labelMarcaNacionalOuImportada
            // 
            this.labelMarcaNacionalOuImportada.AutoSize = true;
            this.labelMarcaNacionalOuImportada.Location = new System.Drawing.Point(439, 249);
            this.labelMarcaNacionalOuImportada.Name = "labelMarcaNacionalOuImportada";
            this.labelMarcaNacionalOuImportada.Size = new System.Drawing.Size(264, 20);
            this.labelMarcaNacionalOuImportada.TabIndex = 9;
            this.labelMarcaNacionalOuImportada.Text = "A marca possui manutenção no Brasil?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 27);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(439, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 27);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(439, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 27);
            this.textBox3.TabIndex = 12;
            // 
            // dateTimePickerDataDeFundacaoMarca
            // 
            this.dateTimePickerDataDeFundacaoMarca.Location = new System.Drawing.Point(439, 219);
            this.dateTimePickerDataDeFundacaoMarca.Name = "dateTimePickerDataDeFundacaoMarca";
            this.dateTimePickerDataDeFundacaoMarca.Size = new System.Drawing.Size(318, 27);
            this.dateTimePickerDataDeFundacaoMarca.TabIndex = 13;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(439, 272);
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
            this.radioButtonNao.Location = new System.Drawing.Point(562, 272);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonNao);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.dateTimePickerDataDeFundacaoMarca);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelMarcaNacionalOuImportada);
            this.Controls.Add(this.labelAnoFundacaoMarca);
            this.Controls.Add(this.labelPaisOrigemMarca);
            this.Controls.Add(this.labelGrupoProprietarioMarca);
            this.Controls.Add(this.labelNomeMarca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Name = "MarcaForm";
            this.Text = "MarcaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private DataGridView dataGridView1;
        private Label labelNomeMarca;
        private Label labelGrupoProprietarioMarca;
        private Label labelPaisOrigemMarca;
        private Label labelAnoFundacaoMarca;
        private Label labelMarcaNacionalOuImportada;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePickerDataDeFundacaoMarca;
        private RadioButton radioButtonSim;
        private RadioButton radioButtonNao;
    }
}