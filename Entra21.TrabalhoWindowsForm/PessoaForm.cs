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
            ListarPessoas();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

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
            //dateTimePickerDataNascimento. = pessoa.DataNascimento;
            comboBoxEndereco.SelectedItem = pessoa.Endereco;
            comboBoxSexo.SelectedItem = pessoa.Sexo;
            maskedTextBoxCpf.Text = pessoa.Cpf;
            maskedTextBoxRg.Text = pessoa.Rg;
            checkBoxCarro.Checked = pessoa.PossuiCarro;
            checkBoxMoto.Checked = pessoa.PossuiMoto;

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarPessoa(string nome, DateTime dataNascimento, int codigo, string sexo, string cpf, string rg, bool possuiCarro, bool possuiMoto)
        {
            var pessoa = new Pessoa()
            {
                Codigo = pessoaServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                DataNascimento = dataNascimento,
                Endereco = enderecoServico.ObterPorCodigo(codigo),
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

        private void EditarDados(string nome, DateTime dataNascimento, Endereco endereco, string sexo, string cpf, string rg, bool possuiCarro, bool possuiMoto)
        {
            var pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.DataNascimento = dataNascimento;
            pessoa.Endereco = endereco;
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
                    pessoa.Endereco,
                    pessoa.Sexo,
                    pessoa.Cpf,
                    pessoa.Rg,
                    pessoa.PossuiCarro,
                    pessoa.PossuiMoto
                });
                dataGridView1.ClearSelection();
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            dateTimePickerDataNascimento.Checked = false;
            comboBoxEndereco.ResetText();
            comboBoxSexo.ResetText();
            maskedTextBoxCpf.Text = string.Empty;
            maskedTextBoxRg.Text = string.Empty;
            checkBoxCarro.Checked = false;
            checkBoxMoto.Checked = false;
            dataGridView1.ClearSelection();
        }

        private void PessoaForm_Load(object sender, EventArgs e)
        {
            ListarPessoas();
        }
    }
}
