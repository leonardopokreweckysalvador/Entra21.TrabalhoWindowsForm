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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonEndereco_Click(object sender, EventArgs e)
        {
            var enderecoForm = new EnderecoForm();
            enderecoForm.ShowDialog();
        }
    }
}
