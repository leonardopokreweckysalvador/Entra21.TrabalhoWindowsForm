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
            this.SuspendLayout();
            // 
            // buttonEndereco
            // 
            this.buttonEndereco.Location = new System.Drawing.Point(47, 35);
            this.buttonEndereco.Name = "buttonEndereco";
            this.buttonEndereco.Size = new System.Drawing.Size(75, 23);
            this.buttonEndereco.TabIndex = 0;
            this.buttonEndereco.Text = "Endereço";
            this.buttonEndereco.UseVisualStyleBackColor = true;
            this.buttonEndereco.Click += new System.EventHandler(this.buttonEndereco_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEndereco);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEndereco;
    }
}