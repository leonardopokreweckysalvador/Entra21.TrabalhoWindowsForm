using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.TrabalhoWindowsForm
{
    public partial class EnderecoForm : Form
    {
        public EnderecoForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = string.Empty;
            textBoxBairro.Text = string.Empty;
            textBoxEstado.Text = string.Empty;
            textBoxCidade.Text = string.Empty;
            textBoxBairro.Text = string.Empty;
            textBoxLogradouro.Text = string.Empty;
            textBoxNumero.Text = string.Empty;
            textBoxComplemento.Text = string.Empty;
        }
    }
}
