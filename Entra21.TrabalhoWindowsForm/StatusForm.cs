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
        private PessoaServico pessoaServico;

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

        private void AdicionarStatus(int codigo, DateTime dataCadastro, string nome, string profissao,
            string empresaTrabalho, double salario, bool nomeLimpo, double limiteFinanceiro)
        {
            var status = new Status()
            {
                Codigo = statusServico.ObterUltimoCodigo() + 1,
                DataCadastro = dataCadastro,
                Pessoa = pessoaServico.ObterPorNomePessoa(nome),
                Profissao = profissao,
                EmpresaTrabalho = empresaTrabalho,
                Salario = salario,
                NomeLimpo = nomeLimpo,
                LimiteFinanceiro = limiteFinanceiro
            };

            statusServico.Adcionar(status);
            LimparCampos();
            ListarStatuses();
        }

        private void EditarDados(int codigo, DateTime dataCadastro, Pessoa pessoa, string profissao,
            string empresaTrabalho, double salario, bool nomeLimpo, double limiteFinanceiro)
        {

        }

        private void LimparCampos()
        {
            dateTimePickerDataCadastro.Checked = false;
            comboBoxNomeCompleto.ResetText();
            textBoxProfissao.Clear();
            textBoxEmpresaTrabalho.Clear();
            maskedTextBoxSalario.Text = string.Empty;
            radioButtonNomeLimpo1.Checked = false;
            radioButtonNomeLimpo2.Checked = false;
            maskedTextBoxLimiteFinanceiro.Text = string.Empty;
            dataGridView1.ClearSelection();
        }

        private void ListarStatuses()
        {
            var statuses = statusServico.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < statuses.Count; i++)
            {
                var status = statuses[i];
                dataGridView1.Rows.Add(new object[]
                    {
                    status.Codigo,
                    status.DataCadastro,
                    status.Pessoa,
                    status.Profissao,
                    status.EmpresaTrabalho,
                    status.Salario,
                    status.NomeLimpo,
                    status.LimiteFinanceiro
                    });
            }

            dataGridView1.ClearSelection();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            ListarStatuses();
        }
    }
}
