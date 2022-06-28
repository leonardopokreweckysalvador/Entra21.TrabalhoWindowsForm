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
    public partial class StatusForm : Form
    {
        private StatusServico statusServico;
        
        public StatusForm()
        {
            InitializeComponent();
            statusServico = new StatusServico();
            ListarStatuses();
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

        private void AdicionarStatus(int codigo, DateTime dataCadastro, Pessoa pessoa, string profissao,
            string empresaTrabalho, double salario, bool nomeLimpo, double limiteFinanceiro)
        {

        }

        private void EditarDados(int codigo, DateTime dataCadastro, Pessoa pessoa, string profissao, 
            string empresaTrabalho, double salario, bool nomeLimpo, double limiteFinanceiro)
        {

        }

        private void LimparCampos()
        {

        }

        private void ListarStatuses()
        {

        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            ListarStatuses();
        }

        private void labelSalario_Click(object sender, EventArgs e)
        {

        }

    }
}
