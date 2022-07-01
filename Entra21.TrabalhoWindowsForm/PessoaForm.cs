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
        private EnderecoServico enderecoServico;

        public PessoaForm()
        {
            InitializeComponent();
            pessoaServico = new PessoaServico();
            enderecoServico = new EnderecoServico();
            PreencherDataGridViewComPessoa();            
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma Pessoa para remover");
                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar a Pessoa cadastrada", "Aviso", MessageBoxButtons.YesNo);
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("A pessoa foi salva no sistema.");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var pessoa = pessoaServico.ObterPorCodigo(codigo);
            pessoaServico.Apagar(codigo);
            PreencherDataGridViewComPessoa();
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

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma Pessoa para editar");
                return;
            }
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var pessoa = pessoaServico.ObterPorCodigo(codigo);
            textBoxNome.Text = pessoa.Nome;
            dateTimePickerDataNascimento.Value = pessoa.DataNascimento;
            comboBoxSexo.SelectedItem = pessoa.Sexo;
            maskedTextBoxCpf.Text = pessoa.Cpf;
            maskedTextBoxRg.Text = pessoa.Rg;
            checkBoxCarro.Checked = pessoa.PossuiCarro;
            checkBoxMoto.Checked = pessoa.PossuiMoto;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var dataNascimento = dateTimePickerDataNascimento.Value;
            var codigo = pessoaServico.ObterUltimoCodigo() + 1;
            var sexo = Convert.ToString(comboBoxSexo.SelectedItem);
            var cpf = maskedTextBoxCpf.Text;
            var rg = maskedTextBoxRg.Text;
            var possuiCarro = checkBoxCarro.Checked;
            var possuiMoto = checkBoxMoto.Checked;
            if (dataGridView1.SelectedRows.Count == 0)
                AdicionarPessoa(nome, dataNascimento, codigo, sexo, cpf, rg, possuiCarro, possuiMoto);
            else
                EditarDados(nome, dataNascimento, sexo, cpf, rg, possuiCarro, possuiMoto);
                PreencherDataGridViewComPessoa();
            LimparCampos();
        }

        private void AdicionarPessoa(string nome, DateTime dataNascimento, int codigo,
            string sexo, string cpf, string rg, bool possuiCarro, bool possuiMoto)
        {
            var pessoa = new Pessoa()
            {
                Codigo = pessoaServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                DataNascimento = dataNascimento,
                Sexo = sexo,
                Cpf = cpf,
                Rg = rg,
                PossuiCarro = possuiCarro,
                PossuiMoto = possuiMoto
            };

            pessoaServico.Adicionar(pessoa);
            LimparCampos();
            ListarPessoas();
        }

        private void EditarDados(string nome, DateTime dataNascimento, string sexo, string cpf, string rg, bool possuiCarro, bool possuiMoto)
        {
            var pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.DataNascimento = dataNascimento;
            pessoa.Sexo = sexo;
            pessoa.Cpf = cpf;
            pessoa.Rg = rg;
            pessoa.PossuiCarro = possuiCarro;
            pessoa.PossuiMoto = possuiMoto;
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            pessoa.Codigo = codigo;
            pessoaServico.Editar(pessoa);
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            dateTimePickerDataNascimento.ResetText();
            comboBoxSexo.ResetText();
            maskedTextBoxCpf.Text = string.Empty;
            maskedTextBoxRg.Text = string.Empty;
            checkBoxCarro.Checked = false;
            checkBoxMoto.Checked = false;
            dataGridView1.ClearSelection();
        }

        private void ListarPessoas()
        {
            var pessoas = pessoaServico.ObterTodas();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < pessoas.Count; i++)
            {
                var pessoa = pessoas[i];
                dataGridView1.Rows.Add(new object[]
                {
                    pessoa.Codigo,
                    pessoa.Nome,
                    pessoa.DataNascimento,
                    pessoa.Sexo,
                    pessoa.Cpf,
                    pessoa.Rg,
                    pessoa.PossuiCarro,
                    pessoa.PossuiMoto
                });
                dataGridView1.ClearSelection();
            }
        }

        private void PreencherDataGridViewComPessoa()
        {
            var pessoas = pessoaServico.ObterTodas();
            dataGridView1.Rows.Clear();
            for (var i = 0; i < pessoas.Count; i++)
            {
                var pessoa = pessoas[i];
                dataGridView1.Rows.Add(new object[]
                {
                    pessoa.Codigo,
                    pessoa.Nome,
                    pessoa.DataNascimento.ToString("dd/MM/yyyy"),
                    pessoa.Sexo,
                    pessoa.Cpf,
                    pessoa.Rg,
                    pessoa.PossuiCarro,
                    pessoa.PossuiMoto
                });
            }

            dataGridView1.ClearSelection();
        }

        private void PessoaForm_Load(object sender, EventArgs e)
        {
            ListarPessoas();
        }
    }
}
