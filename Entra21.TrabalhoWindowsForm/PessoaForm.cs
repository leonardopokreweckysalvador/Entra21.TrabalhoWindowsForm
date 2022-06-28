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
        private PessoaServico pessoaServico;

        public PessoaForm()
        {
            InitializeComponent();
            pessoaServico = new PessoaServico();
            ListarPessoas();
        }

        private void labelSexo_Click(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarPessoa()
        {

        }

        private void EditarDados()
        {

        }

        private void ListarPessoas()
        {

        }

        private void LimparCampos()
        {

        }

        private void PessoaForm_Load(object sender, EventArgs e)
        {
            ListarPessoas();
        }
    }
}
