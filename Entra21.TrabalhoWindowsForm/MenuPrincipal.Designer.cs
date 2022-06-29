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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCarros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEndereco
            // 
            this.buttonEndereco.Location = new System.Drawing.Point(26, 16);
            this.buttonEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEndereco.Name = "buttonEndereco";
            this.buttonEndereco.Size = new System.Drawing.Size(202, 133);
            this.buttonEndereco.TabIndex = 0;
            this.buttonEndereco.Text = "Endereço";
            this.buttonEndereco.UseVisualStyleBackColor = true;
            this.buttonEndereco.Click += new System.EventHandler(this.buttonEndereco_Click);
            // 
            // buttonpPessoa
            // 
            this.buttonpPessoa.Location = new System.Drawing.Point(265, 16);
            this.buttonpPessoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonpPessoa.Name = "buttonpPessoa";
            this.buttonpPessoa.Size = new System.Drawing.Size(202, 133);
            this.buttonpPessoa.TabIndex = 1;
            this.buttonpPessoa.Text = "Pessoa";
            this.buttonpPessoa.UseVisualStyleBackColor = true;
            this.buttonpPessoa.Click += new System.EventHandler(this.buttonpPessoa_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(265, 169);
            this.buttonStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(202, 133);
            this.buttonStatus.TabIndex = 2;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 133);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pessoa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCarros
            // 
            this.buttonCarros.Location = new System.Drawing.Point(502, 16);
            this.buttonCarros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCarros.Name = "buttonCarros";
            this.buttonCarros.Size = new System.Drawing.Size(202, 133);
            this.buttonCarros.TabIndex = 4;
            this.buttonCarros.Text = "Carros";
            this.buttonCarros.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 325);
            this.Controls.Add(this.buttonCarros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.buttonpPessoa);
            this.Controls.Add(this.buttonEndereco);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEndereco;
        private Button buttonpPessoa;
        private Button buttonStatus;
        private Button button1;
        private Button buttonCarros;
    }
}