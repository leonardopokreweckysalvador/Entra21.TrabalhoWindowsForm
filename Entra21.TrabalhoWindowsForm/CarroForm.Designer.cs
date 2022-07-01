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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelOpcionais = new System.Windows.Forms.Label();
            this.labelSituaçãoDocumentacao = new System.Windows.Forms.Label();
            this.labelProprietarioVeiculo = new System.Windows.Forms.Label();
            this.labelLoja = new System.Windows.Forms.Label();
            this.labelModeloVeiculo = new System.Windows.Forms.Label();
            this.labelMarcaDoVeiculo = new System.Windows.Forms.Label();
            this.labelPlacaVeiculo = new System.Windows.Forms.Label();
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
            this.textBoxModeloVeiculo = new System.Windows.Forms.TextBox();
            this.comboBoxLoja = new System.Windows.Forms.ComboBox();
            this.textBoxPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.maskedTextBoxRenavamVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.ColumnCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRenavam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLicenciamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOpcionais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarroForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarroForm
            // 
            this.dataGridViewCarroForm.AllowUserToAddRows = false;
            this.dataGridViewCarroForm.AllowUserToDeleteRows = false;
            this.dataGridViewCarroForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarroForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCódigo,
            this.ColumnVeiculo,
            this.ColumnCategoria,
            this.ColumnPlaca,
            this.ColumnRenavam,
            this.ColumnAnoModelo,
            this.ColumnAnoFabricacao,
            this.ColumnProprietario,
            this.ColumnLicenciamento,
            this.ColumnOpcionais});
            this.dataGridViewCarroForm.Location = new System.Drawing.Point(14, 37);
            this.dataGridViewCarroForm.Name = "dataGridViewCarroForm";
            this.dataGridViewCarroForm.ReadOnly = true;
            this.dataGridViewCarroForm.RowHeadersWidth = 51;
            this.dataGridViewCarroForm.RowTemplate.Height = 29;
            this.dataGridViewCarroForm.Size = new System.Drawing.Size(1081, 632);
            this.dataGridViewCarroForm.TabIndex = 0;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(16, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(117, 3);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelOpcionais
            // 
            this.labelOpcionais.AutoSize = true;
            this.labelOpcionais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpcionais.Location = new System.Drawing.Point(1115, 437);
            this.labelOpcionais.Name = "labelOpcionais";
            this.labelOpcionais.Size = new System.Drawing.Size(267, 20);
            this.labelOpcionais.TabIndex = 4;
            this.labelOpcionais.Text = "Opcionais e características do veículo";
            // 
            // labelSituaçãoDocumentacao
            // 
            this.labelSituaçãoDocumentacao.AutoSize = true;
            this.labelSituaçãoDocumentacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSituaçãoDocumentacao.Location = new System.Drawing.Point(1116, 375);
            this.labelSituaçãoDocumentacao.Name = "labelSituaçãoDocumentacao";
            this.labelSituaçãoDocumentacao.Size = new System.Drawing.Size(189, 20);
            this.labelSituaçãoDocumentacao.TabIndex = 17;
            this.labelSituaçãoDocumentacao.Text = "Documentação do veículo";
            // 
            // labelProprietarioVeiculo
            // 
            this.labelProprietarioVeiculo.AutoSize = true;
            this.labelProprietarioVeiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProprietarioVeiculo.Location = new System.Drawing.Point(1116, 37);
            this.labelProprietarioVeiculo.Name = "labelProprietarioVeiculo";
            this.labelProprietarioVeiculo.Size = new System.Drawing.Size(169, 20);
            this.labelProprietarioVeiculo.TabIndex = 19;
            this.labelProprietarioVeiculo.Text = "Proprietário do Veículo";
            // 
            // labelLoja
            // 
            this.labelLoja.AutoSize = true;
            this.labelLoja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoja.Location = new System.Drawing.Point(1116, 91);
            this.labelLoja.Name = "labelLoja";
            this.labelLoja.Size = new System.Drawing.Size(245, 20);
            this.labelLoja.TabIndex = 21;
            this.labelLoja.Text = "Loja em que o veículo se encontra";
            // 
            // labelModeloVeiculo
            // 
            this.labelModeloVeiculo.AutoSize = true;
            this.labelModeloVeiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelModeloVeiculo.Location = new System.Drawing.Point(1116, 143);
            this.labelModeloVeiculo.Name = "labelModeloVeiculo";
            this.labelModeloVeiculo.Size = new System.Drawing.Size(138, 20);
            this.labelModeloVeiculo.TabIndex = 23;
            this.labelModeloVeiculo.Text = "Modelo do Veículo";
            // 
            // labelMarcaDoVeiculo
            // 
            this.labelMarcaDoVeiculo.AutoSize = true;
            this.labelMarcaDoVeiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMarcaDoVeiculo.Location = new System.Drawing.Point(1116, 196);
            this.labelMarcaDoVeiculo.Name = "labelMarcaDoVeiculo";
            this.labelMarcaDoVeiculo.Size = new System.Drawing.Size(127, 20);
            this.labelMarcaDoVeiculo.TabIndex = 25;
            this.labelMarcaDoVeiculo.Text = "Marca do veículo";
            // 
            // labelPlacaVeiculo
            // 
            this.labelPlacaVeiculo.AutoSize = true;
            this.labelPlacaVeiculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlacaVeiculo.Location = new System.Drawing.Point(1116, 249);
            this.labelPlacaVeiculo.Name = "labelPlacaVeiculo";
            this.labelPlacaVeiculo.Size = new System.Drawing.Size(121, 20);
            this.labelPlacaVeiculo.TabIndex = 27;
            this.labelPlacaVeiculo.Text = "Placa do Veículo";
            // 
            // labelRenavam
            // 
            this.labelRenavam.AutoSize = true;
            this.labelRenavam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRenavam.Location = new System.Drawing.Point(1248, 249);
            this.labelRenavam.Name = "labelRenavam";
            this.labelRenavam.Size = new System.Drawing.Size(150, 20);
            this.labelRenavam.TabIndex = 29;
            this.labelRenavam.Text = "Renavam do Veículo";
            // 
            // comboBoxMarcaVeiculo
            // 
            this.comboBoxMarcaVeiculo.FormattingEnabled = true;
            this.comboBoxMarcaVeiculo.Location = new System.Drawing.Point(1115, 219);
            this.comboBoxMarcaVeiculo.Name = "comboBoxMarcaVeiculo";
            this.comboBoxMarcaVeiculo.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMarcaVeiculo.TabIndex = 30;
            // 
            // labelAnoFabricacao
            // 
            this.labelAnoFabricacao.AutoSize = true;
            this.labelAnoFabricacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAnoFabricacao.Location = new System.Drawing.Point(1116, 301);
            this.labelAnoFabricacao.Name = "labelAnoFabricacao";
            this.labelAnoFabricacao.Size = new System.Drawing.Size(139, 20);
            this.labelAnoFabricacao.TabIndex = 31;
            this.labelAnoFabricacao.Text = "Ano de fabricação ";
            // 
            // labelaAnoModelo
            // 
            this.labelaAnoModelo.AutoSize = true;
            this.labelaAnoModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelaAnoModelo.Location = new System.Drawing.Point(1248, 301);
            this.labelaAnoModelo.Name = "labelaAnoModelo";
            this.labelaAnoModelo.Size = new System.Drawing.Size(117, 20);
            this.labelaAnoModelo.TabIndex = 32;
            this.labelaAnoModelo.Text = "Ano do modelo";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1408, 640);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 36;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(1307, 640);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 35;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // checkBoxTravaEletrica
            // 
            this.checkBoxTravaEletrica.AutoSize = true;
            this.checkBoxTravaEletrica.Location = new System.Drawing.Point(1115, 464);
            this.checkBoxTravaEletrica.Name = "checkBoxTravaEletrica";
            this.checkBoxTravaEletrica.Size = new System.Drawing.Size(119, 24);
            this.checkBoxTravaEletrica.TabIndex = 37;
            this.checkBoxTravaEletrica.Text = "Trava Elétrica";
            this.checkBoxTravaEletrica.UseVisualStyleBackColor = true;
            // 
            // checkBoxVidrosEletricos
            // 
            this.checkBoxVidrosEletricos.AutoSize = true;
            this.checkBoxVidrosEletricos.Location = new System.Drawing.Point(1115, 493);
            this.checkBoxVidrosEletricos.Name = "checkBoxVidrosEletricos";
            this.checkBoxVidrosEletricos.Size = new System.Drawing.Size(133, 24);
            this.checkBoxVidrosEletricos.TabIndex = 38;
            this.checkBoxVidrosEletricos.Text = "Vidros Elétricos";
            this.checkBoxVidrosEletricos.UseVisualStyleBackColor = true;
            // 
            // checkBoxDirecaoHidraulica
            // 
            this.checkBoxDirecaoHidraulica.AutoSize = true;
            this.checkBoxDirecaoHidraulica.Location = new System.Drawing.Point(1115, 524);
            this.checkBoxDirecaoHidraulica.Name = "checkBoxDirecaoHidraulica";
            this.checkBoxDirecaoHidraulica.Size = new System.Drawing.Size(155, 24);
            this.checkBoxDirecaoHidraulica.TabIndex = 39;
            this.checkBoxDirecaoHidraulica.Text = "Direção Hidráulica";
            this.checkBoxDirecaoHidraulica.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombustivelGasolina
            // 
            this.checkBoxCombustivelGasolina.AutoSize = true;
            this.checkBoxCombustivelGasolina.Location = new System.Drawing.Point(1291, 524);
            this.checkBoxCombustivelGasolina.Name = "checkBoxCombustivelGasolina";
            this.checkBoxCombustivelGasolina.Size = new System.Drawing.Size(177, 24);
            this.checkBoxCombustivelGasolina.TabIndex = 40;
            this.checkBoxCombustivelGasolina.Text = "Combustível: Gasolina";
            this.checkBoxCombustivelGasolina.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombustivelAlcool
            // 
            this.checkBoxCombustivelAlcool.AutoSize = true;
            this.checkBoxCombustivelAlcool.Location = new System.Drawing.Point(1291, 584);
            this.checkBoxCombustivelAlcool.Name = "checkBoxCombustivelAlcool";
            this.checkBoxCombustivelAlcool.Size = new System.Drawing.Size(163, 24);
            this.checkBoxCombustivelAlcool.TabIndex = 41;
            this.checkBoxCombustivelAlcool.Text = "Combustível: Alcool";
            this.checkBoxCombustivelAlcool.UseVisualStyleBackColor = true;
            // 
            // checkBoxCambioAutomatico
            // 
            this.checkBoxCambioAutomatico.AutoSize = true;
            this.checkBoxCambioAutomatico.Location = new System.Drawing.Point(1115, 584);
            this.checkBoxCambioAutomatico.Name = "checkBoxCambioAutomatico";
            this.checkBoxCambioAutomatico.Size = new System.Drawing.Size(165, 24);
            this.checkBoxCambioAutomatico.TabIndex = 42;
            this.checkBoxCambioAutomatico.Text = "Câmbio Automático";
            this.checkBoxCambioAutomatico.UseVisualStyleBackColor = true;
            // 
            // checkBoxDirecaoEletrica
            // 
            this.checkBoxDirecaoEletrica.AutoSize = true;
            this.checkBoxDirecaoEletrica.Location = new System.Drawing.Point(1115, 555);
            this.checkBoxDirecaoEletrica.Name = "checkBoxDirecaoEletrica";
            this.checkBoxDirecaoEletrica.Size = new System.Drawing.Size(136, 24);
            this.checkBoxDirecaoEletrica.TabIndex = 43;
            this.checkBoxDirecaoEletrica.Text = "Direção Elétrica";
            this.checkBoxDirecaoEletrica.UseVisualStyleBackColor = true;
            // 
            // checkBoxComputadorDeBordo
            // 
            this.checkBoxComputadorDeBordo.AutoSize = true;
            this.checkBoxComputadorDeBordo.Location = new System.Drawing.Point(1291, 493);
            this.checkBoxComputadorDeBordo.Name = "checkBoxComputadorDeBordo";
            this.checkBoxComputadorDeBordo.Size = new System.Drawing.Size(181, 24);
            this.checkBoxComputadorDeBordo.TabIndex = 44;
            this.checkBoxComputadorDeBordo.Text = "Computador de Bordo";
            this.checkBoxComputadorDeBordo.UseVisualStyleBackColor = true;
            // 
            // checkBoxBancosEmCouro
            // 
            this.checkBoxBancosEmCouro.AutoSize = true;
            this.checkBoxBancosEmCouro.Location = new System.Drawing.Point(1115, 613);
            this.checkBoxBancosEmCouro.Name = "checkBoxBancosEmCouro";
            this.checkBoxBancosEmCouro.Size = new System.Drawing.Size(147, 24);
            this.checkBoxBancosEmCouro.TabIndex = 45;
            this.checkBoxBancosEmCouro.Text = "Bancos em Couro";
            this.checkBoxBancosEmCouro.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombustivelDiesel
            // 
            this.checkBoxCombustivelDiesel.AutoSize = true;
            this.checkBoxCombustivelDiesel.Location = new System.Drawing.Point(1291, 555);
            this.checkBoxCombustivelDiesel.Name = "checkBoxCombustivelDiesel";
            this.checkBoxCombustivelDiesel.Size = new System.Drawing.Size(161, 24);
            this.checkBoxCombustivelDiesel.TabIndex = 46;
            this.checkBoxCombustivelDiesel.Text = "Combustível: Diesel";
            this.checkBoxCombustivelDiesel.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombustivelFlex
            // 
            this.checkBoxCombustivelFlex.AutoSize = true;
            this.checkBoxCombustivelFlex.Location = new System.Drawing.Point(1291, 613);
            this.checkBoxCombustivelFlex.Name = "checkBoxCombustivelFlex";
            this.checkBoxCombustivelFlex.Size = new System.Drawing.Size(146, 24);
            this.checkBoxCombustivelFlex.TabIndex = 47;
            this.checkBoxCombustivelFlex.Text = "Combustível: Flex";
            this.checkBoxCombustivelFlex.UseVisualStyleBackColor = true;
            // 
            // checkBoxArCondicionado
            // 
            this.checkBoxArCondicionado.AutoSize = true;
            this.checkBoxArCondicionado.Location = new System.Drawing.Point(1291, 464);
            this.checkBoxArCondicionado.Name = "checkBoxArCondicionado";
            this.checkBoxArCondicionado.Size = new System.Drawing.Size(141, 24);
            this.checkBoxArCondicionado.TabIndex = 48;
            this.checkBoxArCondicionado.Text = "Ar condicionado";
            this.checkBoxArCondicionado.UseVisualStyleBackColor = true;
            // 
            // radioButtonLicenciamentoEmDia
            // 
            this.radioButtonLicenciamentoEmDia.AutoSize = true;
            this.radioButtonLicenciamentoEmDia.Checked = true;
            this.radioButtonLicenciamentoEmDia.Location = new System.Drawing.Point(1115, 397);
            this.radioButtonLicenciamentoEmDia.Name = "radioButtonLicenciamentoEmDia";
            this.radioButtonLicenciamentoEmDia.Size = new System.Drawing.Size(176, 24);
            this.radioButtonLicenciamentoEmDia.TabIndex = 49;
            this.radioButtonLicenciamentoEmDia.TabStop = true;
            this.radioButtonLicenciamentoEmDia.Text = "Licenciamento em dia";
            this.radioButtonLicenciamentoEmDia.UseVisualStyleBackColor = true;
            // 
            // radioButtonLicenciamentoEmAtraso
            // 
            this.radioButtonLicenciamentoEmAtraso.AutoSize = true;
            this.radioButtonLicenciamentoEmAtraso.Location = new System.Drawing.Point(1312, 397);
            this.radioButtonLicenciamentoEmAtraso.Name = "radioButtonLicenciamentoEmAtraso";
            this.radioButtonLicenciamentoEmAtraso.Size = new System.Drawing.Size(196, 24);
            this.radioButtonLicenciamentoEmAtraso.TabIndex = 50;
            this.radioButtonLicenciamentoEmAtraso.Text = "Licenciamento em atraso";
            this.radioButtonLicenciamentoEmAtraso.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerAnoFabricacao
            // 
            this.dateTimePickerAnoFabricacao.CustomFormat = "yyyy";
            this.dateTimePickerAnoFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAnoFabricacao.Location = new System.Drawing.Point(1115, 325);
            this.dateTimePickerAnoFabricacao.Name = "dateTimePickerAnoFabricacao";
            this.dateTimePickerAnoFabricacao.Size = new System.Drawing.Size(73, 27);
            this.dateTimePickerAnoFabricacao.TabIndex = 51;
            // 
            // dateTimePickerAnoModelo
            // 
            this.dateTimePickerAnoModelo.CustomFormat = "yyyy";
            this.dateTimePickerAnoModelo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAnoModelo.Location = new System.Drawing.Point(1248, 325);
            this.dateTimePickerAnoModelo.Name = "dateTimePickerAnoModelo";
            this.dateTimePickerAnoModelo.Size = new System.Drawing.Size(75, 27);
            this.dateTimePickerAnoModelo.TabIndex = 52;
            // 
            // comboBoxProprietario
            // 
            this.comboBoxProprietario.FormattingEnabled = true;
            this.comboBoxProprietario.Location = new System.Drawing.Point(1115, 61);
            this.comboBoxProprietario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxProprietario.Name = "comboBoxProprietario";
            this.comboBoxProprietario.Size = new System.Drawing.Size(303, 28);
            this.comboBoxProprietario.TabIndex = 53;
            // 
            // textBoxModeloVeiculo
            // 
            this.textBoxModeloVeiculo.Location = new System.Drawing.Point(1116, 165);
            this.textBoxModeloVeiculo.Name = "textBoxModeloVeiculo";
            this.textBoxModeloVeiculo.Size = new System.Drawing.Size(381, 27);
            this.textBoxModeloVeiculo.TabIndex = 22;
            // 
            // comboBoxLoja
            // 
            this.comboBoxLoja.FormattingEnabled = true;
            this.comboBoxLoja.Location = new System.Drawing.Point(1115, 114);
            this.comboBoxLoja.Name = "comboBoxLoja";
            this.comboBoxLoja.Size = new System.Drawing.Size(303, 28);
            this.comboBoxLoja.TabIndex = 54;
            // 
            // textBoxPlacaVeiculo
            // 
            this.textBoxPlacaVeiculo.Location = new System.Drawing.Point(1115, 271);
            this.textBoxPlacaVeiculo.Name = "textBoxPlacaVeiculo";
            this.textBoxPlacaVeiculo.Size = new System.Drawing.Size(125, 27);
            this.textBoxPlacaVeiculo.TabIndex = 55;
            // 
            // maskedTextBoxRenavamVeiculo
            // 
            this.maskedTextBoxRenavamVeiculo.Location = new System.Drawing.Point(1246, 271);
            this.maskedTextBoxRenavamVeiculo.Mask = "999.999.999";
            this.maskedTextBoxRenavamVeiculo.Name = "maskedTextBoxRenavamVeiculo";
            this.maskedTextBoxRenavamVeiculo.Size = new System.Drawing.Size(152, 27);
            this.maskedTextBoxRenavamVeiculo.TabIndex = 56;
            // 
            // ColumnCódigo
            // 
            this.ColumnCódigo.HeaderText = "Código";
            this.ColumnCódigo.MinimumWidth = 6;
            this.ColumnCódigo.Name = "ColumnCódigo";
            this.ColumnCódigo.ReadOnly = true;
            this.ColumnCódigo.Visible = false;
            this.ColumnCódigo.Width = 125;
            // 
            // ColumnVeiculo
            // 
            this.ColumnVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnVeiculo.HeaderText = "Veículo";
            this.ColumnVeiculo.MinimumWidth = 6;
            this.ColumnVeiculo.Name = "ColumnVeiculo";
            this.ColumnVeiculo.ReadOnly = true;
            this.ColumnVeiculo.Width = 86;
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
            this.ColumnAnoModelo.Width = 121;
            // 
            // ColumnAnoFabricacao
            // 
            this.ColumnAnoFabricacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnAnoFabricacao.HeaderText = "Ano Fabricação";
            this.ColumnAnoFabricacao.MinimumWidth = 6;
            this.ColumnAnoFabricacao.Name = "ColumnAnoFabricacao";
            this.ColumnAnoFabricacao.ReadOnly = true;
            this.ColumnAnoFabricacao.Width = 140;
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
            this.ColumnOpcionais.Visible = false;
            // 
            // CarroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 681);
            this.Controls.Add(this.maskedTextBoxRenavamVeiculo);
            this.Controls.Add(this.textBoxPlacaVeiculo);
            this.Controls.Add(this.comboBoxLoja);
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
            this.Controls.Add(this.labelPlacaVeiculo);
            this.Controls.Add(this.labelMarcaDoVeiculo);
            this.Controls.Add(this.labelModeloVeiculo);
            this.Controls.Add(this.textBoxModeloVeiculo);
            this.Controls.Add(this.labelLoja);
            this.Controls.Add(this.labelProprietarioVeiculo);
            this.Controls.Add(this.labelSituaçãoDocumentacao);
            this.Controls.Add(this.labelOpcionais);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewCarroForm);
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
        private Label labelModeloVeiculo;
        private Label labelMarcaDoVeiculo;
        private Label labelPlacaVeiculo;
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
        private ComboBox comboBoxProprietario;
        private TextBox textBoxModeloVeiculo;
        private ComboBox comboBoxLoja;
        private TextBox textBoxPlacaVeiculo;
        private MaskedTextBox maskedTextBoxRenavamVeiculo;
        private DataGridViewTextBoxColumn ColumnCódigo;
        private DataGridViewTextBoxColumn ColumnVeiculo;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPlaca;
        private DataGridViewTextBoxColumn ColumnRenavam;
        private DataGridViewTextBoxColumn ColumnAnoModelo;
        private DataGridViewTextBoxColumn ColumnAnoFabricacao;
        private DataGridViewTextBoxColumn ColumnProprietario;
        private DataGridViewTextBoxColumn ColumnLicenciamento;
        private DataGridViewTextBoxColumn ColumnOpcionais;
    }
}