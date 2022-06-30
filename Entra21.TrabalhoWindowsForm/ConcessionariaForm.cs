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
    public partial class ConcessionariaForm : Form
    {
        private ConcessionariaServico concessionariaServico;
        private EnderecoServico enderecoServico;
        private PessoaServico pessoaServico;

        public ConcessionariaForm()
        {
            InitializeComponent();

            concessionariaServico = new ConcessionariaServico();

            enderecoServico = new EnderecoServico();

            pessoaServico = new PessoaServico();

            PreencherComboBoxComOsNomesPessoas();

            PreencherComboBoxComOsLogradouroEndereco();

            preencherDataGridViewConcessionaria();

        }

        private void preencherDataGridViewConcessionaria()
        {
            var concessionarias = concessionariaServico.ObterTodos(checkBoxApertoFinalSemana.Checked);

            dataGridViewConcessionaria.Rows.Clear();

            for (var i = 0; i < concessionarias.Count; i++)
            {
                var concessionaria = concessionarias[i];

                dataGridViewConcessionaria.Rows.Add(new object[]
                {
                        concessionaria.Codigo,
                        concessionaria.Nome,
                        concessionaria.Endereco,
                        concessionaria.Cnpj,
                        concessionaria.RazaoSocial,
                        concessionaria.DataAbertura,
                        concessionaria.HoraAbre,
                        concessionaria.HoraFecha,
                        concessionaria.AbreFinalSemana,
                        concessionaria.Proprietario
                });
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var cnpj = maskedTextBoxCnpj.Text;
            var razaoSocial = textBoxRazaoSocial.Text;
            var proprietario = Convert.ToString(comboBoxProprietario.SelectedItem);
            var endereco = Convert.ToString(comboBoxEndereco.SelectedItem);
            var dataAbertura = dateTimePickerDataAbertura.Value;
            var horaAbre = dateTimePickerHoraAbre.Value;
            var horaFecha = dateTimePickerHoraFecha.Value;
            var abreFinalSemana = radioButtonAbreFinalSemana.Checked;

            var dadosValidar = ValidarDados(nome, cnpj, razaoSocial, proprietario, endereco, dataAbertura, horaAbre, horaFecha, abreFinalSemana);

            if (dadosValidar == false) return;

            CadastrarConcessionaria(nome, cnpj, razaoSocial, proprietario, endereco, dataAbertura, horaAbre, horaFecha, abreFinalSemana);

        }

        private void CadastrarConcessionaria(string nome, string cnpj, string razaoSocial, string? proprietario, string? endereco, DateTime dataAbertura, DateTime horaAbre, DateTime horaFecha, bool abreFinalSemana)
        {
            var concessionaria = new Concessionaria();

            concessionaria.Codigo = concessionariaServico.ObterUltimoCodigo() + 1;
            concessionaria.Nome = nome;
            concessionaria.Cnpj = cnpj;
            concessionaria.RazaoSocial = razaoSocial;
            concessionaria.DataAbertura = dataAbertura;
            concessionaria.HoraAbre = horaAbre;
            concessionaria.HoraFecha = horaFecha;
            concessionaria.AbreFinalSemana = abreFinalSemana;
            concessionaria.Proprietario = pessoaServico.ObterPorNomePessoa(proprietario);
            concessionaria.Endereco = enderecoServico.ObterPorLogredouro(endereco);

            concessionariaServico.Adicionar(concessionaria);

        }

        private bool ValidarDados(string nome, string cnpj, string razaoSocial, object proprietario, object endereco, DateTime dataAbertura, DateTime horaAbre1, DateTime horaAbre2, bool abreFinalSemana)
        {
            if (nome.Trim().Length < 5)
            {
                MessageBox.Show("Nome da concessionaria invalido!");

                textBoxNome.Focus();

                return false;
            }
            return true;
        }

        private void PreencherComboBoxComOsLogradouroEndereco()
        {
            var enderecos = enderecoServico.ObterTodos();

            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];
                comboBoxEndereco.Items.Add(endereco.Logradouro + ", " + endereco.Numero);

            }
        }

        private void PreencherComboBoxComOsNomesPessoas()
        {
            var pessoas = pessoaServico.ObterTodas();

            for (var i = 0; i < pessoas.Count; i++)
            {
                var pessoa = pessoas[i];
                comboBoxProprietario.Items.Add(pessoa.Nome);
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            maskedTextBoxCnpj.Text = string.Empty;
            textBoxRazaoSocial.Text = string.Empty;
            comboBoxProprietario.ResetText();
            comboBoxEndereco.ResetText();
            dateTimePickerDataAbertura.ResetText();
            dateTimePickerHoraAbre.Text = string.Empty;
            dateTimePickerHoraFecha.Text = string.Empty;
            radioButtonAbreFinalSemana.Checked = true;
            dataGridViewConcessionaria.ClearSelection();
        }

        private void ConcessionariaForm_Load(object sender, EventArgs e)
        {
            preencherDataGridViewConcessionaria();
        }

        private void checkBoxApertoFinalSemana_Click(object sender, EventArgs e)
        {
            preencherDataGridViewConcessionaria();

            LimparCampos();
        }
    }
}
