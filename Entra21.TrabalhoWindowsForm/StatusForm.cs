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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um status para remover");
                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar o Status", "Aviso", MessageBoxButtons.YesNo);
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("O seu registro foi salvo.");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var status = statusServico.ObterPorCodigo(codigo);
            statusServico.Apagar(codigo);
            PreencherDataGridViewComStatus();
            dataGridView1.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var dataCadastro = dateTimePickerDataCadastro.Value;
            var nome = Convert.ToString(comboBoxNomeCompleto.SelectedItem);
            var profissao = textBoxProfissao.Text;
            var empresaTrabalho = textBoxEmpresaTrabalho.Text;
            var salario = Convert.ToDouble(maskedTextBoxSalario.Text);
            var nomeLimpo = radioButtonNomeLimpo1.Checked;
            var limiteFinanceiro = Convert.ToDouble(maskedTextBoxLimiteFinanceiro.Text);
            var endereco = comboBoxEndereco.SelectedItem;
            if (dataGridView1.SelectedRows.Count == 0)
                AdicionarStatus(dataCadastro, nome, profissao, empresaTrabalho, salario, nomeLimpo, limiteFinanceiro);
            else
                EditarDados(dataCadastro, nome, profissao, empresaTrabalho, salario, nomeLimpo, limiteFinanceiro);
            PreencherDataGridViewComStatus();
            LimparCampos();
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var status = statusServico.ObterPorCodigo(codigo);

            //dateTimePickerDataCadastro =
            comboBoxNomeCompleto.SelectedItem = status.Pessoa;
            textBoxProfissao.Text = status.Profissao;
            textBoxEmpresaTrabalho.Text = status.EmpresaTrabalho;
            maskedTextBoxSalario.Text = Convert.ToString(status.Salario);
            radioButtonNomeLimpo1.Checked = status.NomeLimpo;
            radioButtonNomeLimpo2.Checked = status.NomeLimpo;
            maskedTextBoxLimiteFinanceiro.Text = Convert.ToString(status.LimiteFinanceiro);
        }

        private void AdicionarStatus(DateTime dataCadastro, string nome, string profissao,
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

        private void EditarDados(DateTime dataCadastro, string nome, string profissao,
            string empresaTrabalho, double salario, bool nomeLimpo, double limiteFinanceiro)
        {
            var status = new Status();
            status.DataCadastro = dataCadastro;
            status.Pessoa = pessoaServico.ObterPorNomePessoa(nome);
            status.Profissao = profissao;
            status.EmpresaTrabalho = empresaTrabalho;
            status.Salario = salario;
            status.NomeLimpo = nomeLimpo;
            status.LimiteFinanceiro = limiteFinanceiro;
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            status.Codigo = codigo;
            statusServico.Editar(status);
            LimparCampos();
            ListarStatuses();
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

        private void PreencherComboBoxComOsNomesDasPessoas()
        {

        }

        private void PreencherComboBoxComOsEnderecos()
        {

        }

        private void PreencherDataGridViewComStatus()
        {

        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            ListarStatuses();
        }
    }
}
