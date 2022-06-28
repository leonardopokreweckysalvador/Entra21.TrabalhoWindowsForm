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
    public partial class PessoaForm : Form
    {
        private List<Pessoa> pesoas;
        private int codigo = 0;
        private int linhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PessoaForm()
        {
            InitializeComponent();
        }

        private void labelSexo_Click(object sender, EventArgs e)
        {

        }
    }
}
