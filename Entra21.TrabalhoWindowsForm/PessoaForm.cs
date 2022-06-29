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

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

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

        private void EditarDados(int nome, DateTime dataNascimento, Endereco endereco, string Sexo, string Cpf, string Rg, string possuiVeiculo)
        {

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
