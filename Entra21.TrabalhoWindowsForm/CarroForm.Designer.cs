namespace Entra21.TrabalhoWindowsForm
{
    partial class CarroForm
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
            this.dataGridViewCarroForm = new System.Windows.Forms.DataGridView();
            this.ColumnVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRenavam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLicenciamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOpcionais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelOpcionais = new System.Windows.Forms.Label();
            this.labelSituaçãoDocumentacao = new System.Windows.Forms.Label();
            this.labelProprietarioVeiculo = new System.Windows.Forms.Label();
            this.labelLoja = new System.Windows.Forms.Label();
            this.textBoxLocalizacaoVeiculo = new System.Windows.Forms.TextBox();
            this.labelModeloVeiculo = new System.Windows.Forms.Label();
            this.textBoxModeloVeiculo = new System.Windows.Forms.TextBox();
            this.labelMarcaDoVeiculo = new System.Windows.Forms.Label();
            this.maskedTextBoxPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.labelPlacaVeiculo = new System.Windows.Forms.Label();
            this.textBoxRenavam = new System.Windows.Forms.TextBox();
            this.labelRenavam = new System.Windows.Forms.Label();
            this.comboBoxMarcaVeiculo = new System.Windows.Forms.ComboBox();
            this.labelAnoFabricacao = new System.Windows.Forms.Label();
            this.labelaAnoModelo = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.checkBoxTravaEletrica = new System.Windows.Forms.CheckBox();
            this.checkBoxVidrosEletricos = new System.Windows.Forms.CheckBox();
            this.checkBoxDirecaoHidraulica = new System.Windows.Forms.CheckBox();
            this.checkBoxCombustivelGasolina = new System.Windows.Forms.CheckBox();
            this.checkBoxCombustivelAlcool = new System.Windows.Forms.CheckBox();
            this.checkBoxCambioAutomatico = new System.Windows.Forms.CheckBox();
            this.checkBoxDirecaoEletrica = new System.Windows.Forms.CheckBox();
            this.checkBoxComputadorDeBordo = new System.Windows.Forms.CheckBox();
            this.checkBoxBancosEmCouro = new System.Windows.Forms.CheckBox();
            this.checkBoxCombustivelDiesel = new System.Windows.Forms.CheckBox();
            this.checkBoxCombustivelFlex = new System.Windows.Forms.CheckBox();
            this.checkBoxArCondicionado = new System.Windows.Forms.CheckBox();
            this.radioButtonLicenciamentoEmDia = new System.Windows.Forms.RadioButton();
            this.radioButtonLicenciamentoEmAtraso = new System.Windows.Forms.RadioButton();
            this.dateTimePickerAnoFabricacao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAnoModelo = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProprietario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarroForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarroForm
            // 
            this.dataGridViewCarroForm.AllowUserToAddRows = false;
            this.dataGridViewCarroForm.AllowUserToDeleteRows = false;
            this.dataGridViewCarroForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarroForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVeiculo,
            this.ColumnCategoria,
            this.ColumnPlaca,
            this.ColumnRenavam,
            this.ColumnAnoModelo,
            this.ColumnAnoFabricacao,
            this.ColumnProprietario,
            this.ColumnLicenciamento,
            this.ColumnOpcionais});
            this.dataGridViewCarroForm.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewCarroForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCarroForm.Name = "dataGridViewCarroForm";
            this.dataGridViewCarroForm.ReadOnly = true;
            this.dataGridViewCarroForm.RowHeadersWidth = 51;
            this.dataGridViewCarroForm.RowTemplate.Height = 29;
            this.dataGridViewCarroForm.Size = new System.Drawing.Size(949, 474);
            this.dataGridViewCarroForm.TabIndex = 0;
            // 
            // ColumnVeiculo
            // 
            this.ColumnVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnVeiculo.HeaderText = "Veículo";
            this.ColumnVeiculo.MinimumWidth = 6;
            this.ColumnVeiculo.Name = "ColumnVeiculo";
            this.ColumnVeiculo.ReadOnly = true;
            this.ColumnVeiculo.Width = 70;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.MinimumWidth = 6;
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            this.ColumnCategoria.Width = 95;
            // 
            // ColumnPlaca
            // 
            this.ColumnPlaca.HeaderText = "Placa";
            this.ColumnPlaca.MinimumWidth = 6;
            this.ColumnPlaca.Name = "ColumnPlaca";
            this.ColumnPlaca.ReadOnly = true;
            this.ColumnPlaca.Width = 85;
            // 
            // ColumnRenavam
            // 
            this.ColumnRenavam.HeaderText = "Nº Renavam";
            this.ColumnRenavam.MinimumWidth = 6;
            this.ColumnRenavam.Name = "ColumnRenavam";
            this.ColumnRenavam.ReadOnly = true;
            this.ColumnRenavam.Width = 125;
            // 
            // ColumnAnoModelo
            // 
            this.ColumnAnoModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnAnoModelo.HeaderText = "Ano Modelo";
            this.ColumnAnoModelo.MinimumWidth = 6;
            this.ColumnAnoModelo.Name = "ColumnAnoModelo";
            this.ColumnAnoModelo.ReadOnly = true;
            this.ColumnAnoModelo.Width = 98;
            // 
            // ColumnAnoFabricacao
            // 
            this.ColumnAnoFabricacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnAnoFabricacao.HeaderText = "Ano Fabricação";
            this.ColumnAnoFabricacao.MinimumWidth = 6;
            this.ColumnAnoFabricacao.Name = "ColumnAnoFabricacao";
            this.ColumnAnoFabricacao.ReadOnly = true;
            this.ColumnAnoFabricacao.Width = 114;
            // 
            // ColumnProprietario
            // 
            this.ColumnProprietario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnProprietario.HeaderText = "Proprietário";
            this.ColumnProprietario.MinimumWidth = 6;
            this.ColumnProprietario.Name = "ColumnProprietario";
            this.ColumnProprietario.ReadOnly = true;
            this.ColumnProprietario.Width = 250;
            // 
            // ColumnLicenciamento
            // 
            this.ColumnLicenciamento.HeaderText = "Licenciamento";
            this.ColumnLicenciamento.MinimumWidth = 6;
            this.ColumnLicenciamento.Name = "ColumnLicenciamento";
            this.ColumnLicenciamento.ReadOnly = true;
            this.ColumnLicenciamento.Width = 125;
            // 
            // ColumnOpcionais
            // 
            this.ColumnOpcionais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOpcionais.HeaderText = "Opcionais";
            this.ColumnOpcionais.MinimumWidth = 6;
            this.ColumnOpcionais.Name = "ColumnOpcionais";
            this.ColumnOpcionais.ReadOnly = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(14, 2);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(82, 22);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(102, 2);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(82, 22);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelOpcionais
            // 
            this.labelOpcionais.AutoSize = true;
            this.labelOpcionais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpcionais.Location = new System.Drawing.Point(966, 328);
            this.labelOpcionais.Name = "labelOpcionais";
            this.labelOpcionais.Size = new System.Drawing.Size(212, 15);
            this.labelOpcionais.TabIndex = 4;
            this.labelOpcionais.Text = "Opcionais e características do veículo";
            // 
            // labelSituaçãoDocumentacao
            // 
            this.labelSituaçãoDocumentacao.AutoSize = true;
            this.labelSituaçãoDocumentacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSituaçãoDocumentacao.Location = new System.Drawing.Point(967, 281);
            this.labelSituaçãoDocumentacao.Name = "labelSituaçãoDocumentacao";
            this.labelSituaçãoDocumentacao.Size = new System.Drawing.Size(151, 15);
            this.labelSituaçãoDocumentacao.TabIndex = 17;
            this.labelSituaçãoDocumentacao.Text = "Documentação do veículo";
            // 
            // labelProprietarioVeiculo
            // 
            this.labelProprietarioVeiculo.AutoSize = true;
            this.labelProprietarioVeiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProprietarioVeiculo.Location = new System.Drawing.Point(967, 28);
            this.labelProprietarioVeiculo.Name = "labelProprietarioVeiculo";
            this.labelProprietarioVeiculo.Size = new System.Drawing.Size(134, 15);
            this.labelProprietarioVeiculo.TabIndex = 19;
            this.labelProprietarioVeiculo.Text = "Proprietário do Veículo";
            // 
            // labelLoja
            // 
            this.labelLoja.AutoSize = true;
            this.labelLoja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoja.Location = new System.Drawing.Point(967, 68);
            this.labelLoja.Name = "labelLoja";
            this.labelLoja.Size = new System.Drawing.Size(195, 15);
            this.labelLoja.TabIndex = 21;
            this.labelLoja.Text = "Loja em que o veículo se encontra";
            // 
            // textBoxLocalizacaoVeiculo
            // 
            this.textBoxLocalizacaoVeiculo.Location = new System.Drawing.Point(967, 85);
            this.textBoxLocalizacaoVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocalizacaoVeiculo.Name = "textBoxLocalizacaoVeiculo";
            this.textBoxLocalizacaoVeiculo.Size = new System.Drawing.Size(334, 23);
            this.textBoxLocalizacaoVeiculo.TabIndex = 20;
            // 
            // labelModeloVeiculo
            // 
            this.labelModeloVeiculo.AutoSize = true;
            this.labelModeloVeiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelModeloVeiculo.Location = new System.Drawing.Point(967, 107);
            this.labelModeloVeiculo.Name = "labelModeloVeiculo";
            this.labelModeloVeiculo.Size = new System.Drawing.Size(109, 15);
            this.labelModeloVeiculo.TabIndex = 23;
            this.labelModeloVeiculo.Text = "Modelo do Veículo";
            // 
            // textBoxModeloVeiculo
            // 
            this.textBoxModeloVeiculo.Location = new System.Drawing.Point(967, 124);
            this.textBoxModeloVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxModeloVeiculo.Name = "textBoxModeloVeiculo";
            this.textBoxModeloVeiculo.Size = new System.Drawing.Size(334, 23);
            this.textBoxModeloVeiculo.TabIndex = 22;
            // 
            // labelMarcaDoVeiculo
            // 
            this.labelMarcaDoVeiculo.AutoSize = true;
            this.labelMarcaDoVeiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMarcaDoVeiculo.Location = new System.Drawing.Point(967, 147);
            this.labelMarcaDoVeiculo.Name = "labelMarcaDoVeiculo";
            this.labelMarcaDoVeiculo.Size = new System.Drawing.Size(101, 15);
            this.labelMarcaDoVeiculo.TabIndex = 25;
            this.labelMarcaDoVeiculo.Text = "Marca do veículo";
            // 
            // maskedTextBoxPlacaVeiculo
            // 
            this.maskedTextBoxPlacaVeiculo.Location = new System.Drawing.Point(967, 204);
            this.maskedTextBoxPlacaVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxPlacaVeiculo.Mask = "999-9999";
            this.maskedTextBoxPlacaVeiculo.Name = "maskedTextBoxPlacaVeiculo";
            this.maskedTextBoxPlacaVeiculo.Size = new System.Drawing.Size(110, 23);
            this.maskedTextBoxPlacaVeiculo.TabIndex = 26;
            // 
            // labelPlacaVeiculo
            // 
            this.labelPlacaVeiculo.AutoSize = true;
            this.labelPlacaVeiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlacaVeiculo.Location = new System.Drawing.Point(967, 187);
            this.labelPlacaVeiculo.Name = "labelPlacaVeiculo";
            this.labelPlacaVeiculo.Size = new System.Drawing.Size(95, 15);
            this.labelPlacaVeiculo.TabIndex = 27;
            this.labelPlacaVeiculo.Text = "Placa do Veículo";
            // 
            // textBoxRenavam
            // 
            this.textBoxRenavam.Location = new System.Drawing.Point(1082, 204);
            this.textBoxRenavam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRenavam.Name = "textBoxRenavam";
            this.textBoxRenavam.Size = new System.Drawing.Size(219, 23);
            this.textBoxRenavam.TabIndex = 28;
            // 
            // labelRenavam
            // 
            this.labelRenavam.AutoSize = true;
            this.labelRenavam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRenavam.Location = new System.Drawing.Point(1082, 187);
            this.labelRenavam.Name = "labelRenavam";
            this.labelRenavam.Size = new System.Drawing.Size(119, 15);
            this.labelRenavam.TabIndex = 29;
            this.labelRenavam.Text = "Renavam do Veículo";
            // 
            // comboBoxMarcaVeiculo
            // 
            this.comboBoxMarcaVeiculo.FormattingEnabled = true;
            this.comboBoxMarcaVeiculo.Location = new System.Drawing.Point(966, 164);
            this.comboBoxMarcaVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMarcaVeiculo.Name = "comboBoxMarcaVeiculo";
            this.comboBoxMarcaVeiculo.Size = new System.Drawing.Size(133, 23);
            this.comboBoxMarcaVeiculo.TabIndex = 30;
            // 
            // labelAnoFabricacao
            // 
            this.labelAnoFabricacao.AutoSize = true;
            this.labelAnoFabricacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAnoFabricacao.Location = new System.Drawing.Point(967, 226);
            this.labelAnoFabricacao.Name = "labelAnoFabricacao";
            this.labelAnoFabricacao.Size = new System.Drawing.Size(109, 15);
            this.labelAnoFabricacao.TabIndex = 31;
            this.labelAnoFabricacao.Text = "Ano de fabricação ";
            // 
            // labelaAnoModelo
            // 
            this.labelaAnoModelo.AutoSize = true;
            this.labelaAnoModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelaAnoModelo.Location = new System.Drawing.Point(1082, 226);
            this.labelaAnoModelo.Name = "labelaAnoModelo";
            this.labelaAnoModelo.Size = new System.Drawing.Size(91, 15);
            this.labelaAnoModelo.TabIndex = 32;
            this.labelaAnoModelo.Text = "Ano do modelo";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1222, 480);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 22);
            this.buttonCancelar.TabIndex = 36;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(1134, 480);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(82, 22);
            this.buttonSalvar.TabIndex = 35;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // checkBoxTravaEletrica
            // 
            this.checkBoxTravaEletrica.AutoSize = true;
            this.checkBoxTravaEletrica.Location = new System.Drawing.Point(966, 348);
            this.checkBoxTravaEletrica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxTravaEletrica.Name = "checkBoxTravaEletrica";
            this.checkBoxTravaEletrica.Size = new System.Drawing.Size(94, 19);
            this.checkBoxTravaEletrica.TabIndex = 37;
            this.checkBoxTravaEletrica.Text = "Trava Elétrica";
            this.checkBoxTravaEletrica.UseVisualStyleBackColor = true;
            // 
            // checkBoxVidrosEletricos
            // 
            this.checkBoxVidrosEletricos.AutoSize = true;
            this.checkBoxVidrosEletricos.Location = new System.Drawing.Point(966, 370);
            this.checkBoxVidrosEletricos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxVidrosEletricos.Name = "checkBoxVidrosEletricos";
            this.checkBoxVidrosEletricos.Size = new System.Drawing.Size(106, 19);
            this.checkBoxVidrosEletricos.TabIndex = 38;
            this.checkBoxVidrosEletricos.Text = "Vidros Elétricos";
            this.checkBoxVidrosEletricos.UseVisualStyleBackColor = true;
            // 
            // checkBoxDirecaoHidraulica
            // 
            this.checkBoxDirecaoHidraulica.AutoSize = true;
            this.checkBoxDirecaoHidraulica.Location = new System.Drawing.Point(966, 393);
            this.checkBoxDirecaoHidraulica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDirecaoHidraulica.Name = "checkBoxDirecaoHidraulica";
            this.checkBoxDirecaoHidraulica.Size = new System.Drawing.Size(123, 19);
            this.checkBoxDirecaoHidraulica.TabIndex = 39;
            this.checkBoxDirecaoHidraulica.Text = "Direção Hidráulica";
            this.checkBoxDirecaoHidraulica.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombustivelGasolina
            // 
            this.checkBoxCombustivelGasolina.AutoSize = true;
            this.checkBoxCombustivelGasolina.Location = new System.Drawing.Point(1120, 393);
            this.checkBoxCombustivelGasolina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCombustivelGasolina.Name = "checkBoxCombustivelGasolina";
            this.checkBoxCombustivelGasolina.Size = new System.Drawing.Size(144, 19);
            this.checkBoxCombustivelGasolina.TabIndex = 40;
            this.checkBoxCombustivelGasolina.Text = "Combustível: Gasolina";
            this.checkBoxCombustivelGasolina.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombustivelAlcool
            // 
            this.checkBoxCombustivelAlcool.AutoSize = true;
            this.checkBoxCombustivelAlcool.Location = new System.Drawing.Point(1120, 438);
            this.checkBoxCombustivelAlcool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCombustivelAlcool.Name = "checkBoxCombustivelAlcool";
            this.checkBoxCombustivelAlcool.Size = new System.Drawing.Size(133, 19);
            this.checkBoxCombustivelAlcool.TabIndex = 41;
            this.checkBoxCombustivelAlcool.Text = "Combustível: Alcool";
            this.checkBoxCombustivelAlcool.UseVisualStyleBackColor = true;
            // 
            // checkBoxCambioAutomatico
            // 
            this.checkBoxCambioAutomatico.AutoSize = true;
            this.checkBoxCambioAutomatico.Location = new System.Drawing.Point(966, 438);
            this.checkBoxCambioAutomatico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCambioAutomatico.Name = "checkBoxCambioAutomatico";
            this.checkBoxCambioAutomatico.Size = new System.Drawing.Size(134, 19);
            this.checkBoxCambioAutomatico.TabIndex = 42;
            this.checkBoxCambioAutomatico.Text = "Câmbio Automático";
            this.checkBoxCambioAutomatico.UseVisualStyleBackColor = true;
            // 
            // checkBoxDirecaoEletrica
            // 
            this.checkBoxDirecaoEletrica.AutoSize = true;
            this.checkBoxDirecaoEletrica.Location = new System.Drawing.Point(966, 416);
            this.checkBoxDirecaoEletrica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDirecaoEletrica.Name = "checkBoxDirecaoEletrica";
            this.checkBoxDirecaoEletrica.Size = new System.Drawing.Size(107, 19);
            this.checkBoxDirecaoEletrica.TabIndex = 43;
            this.checkBoxDirecaoEletrica.Text = "Direção Elétrica";
            this.checkBoxDirecaoEletrica.UseVisualStyleBackColor = true;
            // 
            // checkBoxComputadorDeBordo
            // 
            this.checkBoxComputadorDeBordo.AutoSize = true;
            this.checkBoxComputadorDeBordo.Location = new System.Drawing.Point(1120, 370);
            this.checkBoxComputadorDeBordo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxComputadorDeBordo.Name = "checkBoxComputadorDeBordo";
            this.checkBoxComputadorDeBordo.Size = new System.Drawing.Size(145, 19);
            this.checkBoxComputadorDeBordo.TabIndex = 44;
            this.checkBoxComputadorDeBordo.Text = "Computador de Bordo";
            this.checkBoxComputadorDeBordo.UseVisualStyleBackColor = true;
            // 
            // checkBoxBancosEmCouro
            // 
            this.checkBoxBancosEmCouro.AutoSize = true;
            this.checkBoxBancosEmCouro.Location = new System.Drawing.Point(966, 460);
            this.checkBoxBancosEmCouro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBancosEmCouro.Name = "checkBoxBancosEmCouro";
            this.checkBoxBancosEmCouro.Size = new System.Drawing.Size(120, 19);
            this.checkBoxBancosEmCouro.TabIndex = 45;
            this.checkBoxBancosEmCouro.Text = "Bancos em Couro";
            this.checkBoxBancosEmCouro.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombustivelDiesel
            // 
            this.checkBoxCombustivelDiesel.AutoSize = true;
            this.checkBoxCombustivelDiesel.Location = new System.Drawing.Point(1120, 416);
            this.checkBoxCombustivelDiesel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCombustivelDiesel.Name = "checkBoxCombustivelDiesel";
            this.checkBoxCombustivelDiesel.Size = new System.Drawing.Size(130, 19);
            this.checkBoxCombustivelDiesel.TabIndex = 46;
            this.checkBoxCombustivelDiesel.Text = "Combustível: Diesel";
            this.checkBoxCombustivelDiesel.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombustivelFlex
            // 
            this.checkBoxCombustivelFlex.AutoSize = true;
            this.checkBoxCombustivelFlex.Location = new System.Drawing.Point(1120, 460);
            this.checkBoxCombustivelFlex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCombustivelFlex.Name = "checkBoxCombustivelFlex";
            this.checkBoxCombustivelFlex.Size = new System.Drawing.Size(120, 19);
            this.checkBoxCombustivelFlex.TabIndex = 47;
            this.checkBoxCombustivelFlex.Text = "Combustível: Flex";
            this.checkBoxCombustivelFlex.UseVisualStyleBackColor = true;
            // 
            // checkBoxArCondicionado
            // 
            this.checkBoxArCondicionado.AutoSize = true;
            this.checkBoxArCondicionado.Location = new System.Drawing.Point(1120, 348);
            this.checkBoxArCondicionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxArCondicionado.Name = "checkBoxArCondicionado";
            this.checkBoxArCondicionado.Size = new System.Drawing.Size(114, 19);
            this.checkBoxArCondicionado.TabIndex = 48;
            this.checkBoxArCondicionado.Text = "Ar condicionado";
            this.checkBoxArCondicionado.UseVisualStyleBackColor = true;
            // 
            // radioButtonLicenciamentoEmDia
            // 
            this.radioButtonLicenciamentoEmDia.AutoSize = true;
            this.radioButtonLicenciamentoEmDia.Checked = true;
            this.radioButtonLicenciamentoEmDia.Location = new System.Drawing.Point(966, 298);
            this.radioButtonLicenciamentoEmDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonLicenciamentoEmDia.Name = "radioButtonLicenciamentoEmDia";
            this.radioButtonLicenciamentoEmDia.Size = new System.Drawing.Size(142, 19);
            this.radioButtonLicenciamentoEmDia.TabIndex = 49;
            this.radioButtonLicenciamentoEmDia.TabStop = true;
            this.radioButtonLicenciamentoEmDia.Text = "Licenciamento em dia";
            this.radioButtonLicenciamentoEmDia.UseVisualStyleBackColor = true;
            // 
            // radioButtonLicenciamentoEmAtraso
            // 
            this.radioButtonLicenciamentoEmAtraso.AutoSize = true;
            this.radioButtonLicenciamentoEmAtraso.Location = new System.Drawing.Point(1138, 298);
            this.radioButtonLicenciamentoEmAtraso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonLicenciamentoEmAtraso.Name = "radioButtonLicenciamentoEmAtraso";
            this.radioButtonLicenciamentoEmAtraso.Size = new System.Drawing.Size(158, 19);
            this.radioButtonLicenciamentoEmAtraso.TabIndex = 50;
            this.radioButtonLicenciamentoEmAtraso.Text = "Licenciamento em atraso";
            this.radioButtonLicenciamentoEmAtraso.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerAnoFabricacao
            // 
            this.dateTimePickerAnoFabricacao.CustomFormat = "yyyy";
            this.dateTimePickerAnoFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAnoFabricacao.Location = new System.Drawing.Point(966, 244);
            this.dateTimePickerAnoFabricacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerAnoFabricacao.Name = "dateTimePickerAnoFabricacao";
            this.dateTimePickerAnoFabricacao.Size = new System.Drawing.Size(64, 23);
            this.dateTimePickerAnoFabricacao.TabIndex = 51;
            // 
            // dateTimePickerAnoModelo
            // 
            this.dateTimePickerAnoModelo.CustomFormat = "yyyy";
            this.dateTimePickerAnoModelo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAnoModelo.Location = new System.Drawing.Point(1082, 244);
            this.dateTimePickerAnoModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerAnoModelo.Name = "dateTimePickerAnoModelo";
            this.dateTimePickerAnoModelo.Size = new System.Drawing.Size(92, 23);
            this.dateTimePickerAnoModelo.TabIndex = 52;
            // 
            // comboBoxProprietario
            // 
            this.comboBoxProprietario.FormattingEnabled = true;
            this.comboBoxProprietario.Location = new System.Drawing.Point(966, 46);
            this.comboBoxProprietario.Name = "comboBoxProprietario";
            this.comboBoxProprietario.Size = new System.Drawing.Size(266, 23);
            this.comboBoxProprietario.TabIndex = 53;
            // 
            // CarroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 511);
            this.Controls.Add(this.comboBoxProprietario);
            this.Controls.Add(this.dateTimePickerAnoModelo);
            this.Controls.Add(this.dateTimePickerAnoFabricacao);
            this.Controls.Add(this.radioButtonLicenciamentoEmAtraso);
            this.Controls.Add(this.radioButtonLicenciamentoEmDia);
            this.Controls.Add(this.checkBoxArCondicionado);
            this.Controls.Add(this.checkBoxCombustivelFlex);
            this.Controls.Add(this.checkBoxCombustivelDiesel);
            this.Controls.Add(this.checkBoxBancosEmCouro);
            this.Controls.Add(this.checkBoxComputadorDeBordo);
            this.Controls.Add(this.checkBoxDirecaoEletrica);
            this.Controls.Add(this.checkBoxCambioAutomatico);
            this.Controls.Add(this.checkBoxCombustivelAlcool);
            this.Controls.Add(this.checkBoxCombustivelGasolina);
            this.Controls.Add(this.checkBoxDirecaoHidraulica);
            this.Controls.Add(this.checkBoxVidrosEletricos);
            this.Controls.Add(this.checkBoxTravaEletrica);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelaAnoModelo);
            this.Controls.Add(this.labelAnoFabricacao);
            this.Controls.Add(this.comboBoxMarcaVeiculo);
            this.Controls.Add(this.labelRenavam);
            this.Controls.Add(this.textBoxRenavam);
            this.Controls.Add(this.labelPlacaVeiculo);
            this.Controls.Add(this.maskedTextBoxPlacaVeiculo);
            this.Controls.Add(this.labelMarcaDoVeiculo);
            this.Controls.Add(this.labelModeloVeiculo);
            this.Controls.Add(this.textBoxModeloVeiculo);
            this.Controls.Add(this.labelLoja);
            this.Controls.Add(this.textBoxLocalizacaoVeiculo);
            this.Controls.Add(this.labelProprietarioVeiculo);
            this.Controls.Add(this.labelSituaçãoDocumentacao);
            this.Controls.Add(this.labelOpcionais);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewCarroForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarroForm";
            this.Text = "CarroForm";
            this.Load += new System.EventHandler(this.CarroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarroForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewCarroForm;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelOpcionais;
        private Label labelSituaçãoDocumentacao;
        private Label labelProprietarioVeiculo;
        private Label labelLoja;
        private TextBox textBoxLocalizacaoVeiculo;
        private Label labelModeloVeiculo;
        private TextBox textBoxModeloVeiculo;
        private Label labelMarcaDoVeiculo;
        private MaskedTextBox maskedTextBoxPlacaVeiculo;
        private Label labelPlacaVeiculo;
        private TextBox textBoxRenavam;
        private Label labelRenavam;
        private ComboBox comboBoxMarcaVeiculo;
        private Label labelAnoFabricacao;
        private Label labelaAnoModelo;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private CheckBox checkBoxTravaEletrica;
        private CheckBox checkBoxVidrosEletricos;
        private CheckBox checkBoxDirecaoHidraulica;
        private CheckBox checkBoxCombustivelGasolina;
        private CheckBox checkBoxCombustivelAlcool;
        private CheckBox checkBoxCambioAutomatico;
        private CheckBox checkBoxDirecaoEletrica;
        private CheckBox checkBoxComputadorDeBordo;
        private CheckBox checkBoxBancosEmCouro;
        private CheckBox checkBoxCombustivelDiesel;
        private CheckBox checkBoxCombustivelFlex;
        private CheckBox checkBoxArCondicionado;
        private RadioButton radioButtonLicenciamentoEmDia;
        private RadioButton radioButtonLicenciamentoEmAtraso;
        private DateTimePicker dateTimePickerAnoFabricacao;
        private DateTimePicker dateTimePickerAnoModelo;
        private DataGridViewTextBoxColumn ColumnVeiculo;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPlaca;
        private DataGridViewTextBoxColumn ColumnRenavam;
        private DataGridViewTextBoxColumn ColumnAnoModelo;
        private DataGridViewTextBoxColumn ColumnAnoFabricacao;
        private DataGridViewTextBoxColumn ColumnProprietario;
        private DataGridViewTextBoxColumn ColumnLicenciamento;
        private DataGridViewTextBoxColumn ColumnOpcionais;
        private ComboBox comboBoxProprietario;
    }
}