namespace Entra21.TrabalhoWindowsForm
{
    partial class MenuPrincipal
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
            this.buttonEndereco = new System.Windows.Forms.Button();
            this.buttonpPessoa = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonMarcas = new System.Windows.Forms.Button();
            this.buttonCarros = new System.Windows.Forms.Button();
            this.buttonConcessionaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEndereco
            // 
            this.buttonEndereco.Location = new System.Drawing.Point(23, 12);
            this.buttonEndereco.Name = "buttonEndereco";
            this.buttonEndereco.Size = new System.Drawing.Size(177, 100);
            this.buttonEndereco.TabIndex = 0;
            this.buttonEndereco.Text = "Endereço";
            this.buttonEndereco.UseVisualStyleBackColor = true;
            this.buttonEndereco.Click += new System.EventHandler(this.buttonEndereco_Click);
            // 
            // buttonpPessoa
            // 
            this.buttonpPessoa.Location = new System.Drawing.Point(232, 12);
            this.buttonpPessoa.Name = "buttonpPessoa";
            this.buttonpPessoa.Size = new System.Drawing.Size(177, 100);
            this.buttonpPessoa.TabIndex = 1;
            this.buttonpPessoa.Text = "Pessoa";
            this.buttonpPessoa.UseVisualStyleBackColor = true;
            this.buttonpPessoa.Click += new System.EventHandler(this.buttonpPessoa_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(232, 127);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(177, 100);
            this.buttonStatus.TabIndex = 2;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonMarcas
            // 
            this.buttonMarcas.Location = new System.Drawing.Point(439, 127);
            this.buttonMarcas.Name = "buttonMarcas";
            this.buttonMarcas.Size = new System.Drawing.Size(177, 100);
            this.buttonMarcas.TabIndex = 3;
            this.buttonMarcas.Text = "Marcas";
            this.buttonMarcas.UseVisualStyleBackColor = true;
            // 
            // buttonCarros
            // 
            this.buttonCarros.Location = new System.Drawing.Point(439, 12);
            this.buttonCarros.Name = "buttonCarros";
            this.buttonCarros.Size = new System.Drawing.Size(177, 100);
            this.buttonCarros.TabIndex = 4;
            this.buttonCarros.Text = "Carros";
            this.buttonCarros.UseVisualStyleBackColor = true;
            // 
            // buttonConcessionaria
            // 
            this.buttonConcessionaria.Location = new System.Drawing.Point(23, 127);
            this.buttonConcessionaria.Name = "buttonConcessionaria";
            this.buttonConcessionaria.Size = new System.Drawing.Size(177, 100);
            this.buttonConcessionaria.TabIndex = 5;
            this.buttonConcessionaria.Text = "Concessionaria";
            this.buttonConcessionaria.UseVisualStyleBackColor = true;
            this.buttonConcessionaria.Click += new System.EventHandler(this.buttonConcessionaria_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 244);
            this.Controls.Add(this.buttonConcessionaria);
            this.Controls.Add(this.buttonCarros);
            this.Controls.Add(this.buttonMarcas);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.buttonpPessoa);
            this.Controls.Add(this.buttonEndereco);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEndereco;
        private Button buttonpPessoa;
        private Button buttonStatus;
        private Button buttonMarcas;
        private Button buttonCarros;
        private Button buttonConcessionaria;
    }
}