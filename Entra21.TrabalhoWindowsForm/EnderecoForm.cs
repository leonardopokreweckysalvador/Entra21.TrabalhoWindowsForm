using Newtonsoft.Json;
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
    public partial class EnderecoForm : Form
    {
        private EnderecoServico enderecoServico;

        public EnderecoForm()
        {
            enderecoServico = new EnderecoServico();

            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = string.Empty;
            textBoxBairro.Text = string.Empty;
            textBoxEstado.Text = string.Empty;
            textBoxCidade.Text = string.Empty;
            textBoxBairro.Text = string.Empty;
            textBoxLogradouro.Text = string.Empty;
            textBoxNumero.Text = string.Empty;
            textBoxComplemento.Text = string.Empty;
        }

        private void EnderecoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var cep = maskedTextBoxCep.Text;
            var estado = textBoxEstado.Text;
            var cidade = textBoxCidade.Text;
            var bairro = textBoxBairro.Text;
            var logradouro = textBoxLogradouro.Text;
            var numero = textBoxNumero.Text;
            var complemento = textBoxComplemento.Text;

            var dadosValidar = ValidarDados(cep, estado, cidade, bairro, logradouro, numero, complemento);

            if (dadosValidar == false)
                return;

            if (dataGridViewEndereco.SelectedRows.Count == 0)
            {
                CadastrarEndereco(cep, estado, cidade, bairro, logradouro, numero, complemento);
            }

        }

        private bool ValidarDados(string cep, string estado, string cidade, string bairro, string logradouro, string numero, string complemento)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido!!");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (estado.Trim().Length == 0)
            {
                MessageBox.Show("Estado inválido!!");

                textBoxEstado.Focus();

                return false;
            }

            if (cidade.Trim().Length < 3)
            {
                MessageBox.Show("Cidade inválida!!");

                textBoxCidade.Focus();

                return false;
            }

            if (bairro.Trim().Length < 3)
            {
                MessageBox.Show("Bairro inválido!!");

                textBoxBairro.Focus();

                return false;
            }

            if (logradouro.Trim().Length < 4)
            {
                MessageBox.Show("Logradouro inválido!!");

                textBoxLogradouro.Focus();

                return false;
            }

            if (numero.Trim().Length == 0)
            {
                MessageBox.Show("Número inválido");

                textBoxNumero.Focus();

                return false;
            }

            return true;
        }

        private void CadastrarEndereco(string cep, string estado, string cidade, string bairro, string logradouro, string numero, string complemento)
        {
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.Estado = estado;
            endereco.Cidade = cidade;
            endereco.Bairro = bairro;
            endereco.Logradouro = logradouro;
            endereco.Numero = numero;
            endereco.Complemento = complemento;

            enderecoServico.Adicionar(endereco);
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "");

            if (cep.Length != 8) return;

            var httpCliente = new HttpClient();

            var retorno = httpCliente.GetAsync($"https://viacep.com.br/ws/{cep}/json").Result;

            if (retorno.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resposta = retorno.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEstado.Text = dadosEndereco.Uf;
                textBoxCidade.Text = dadosEndereco.Localidade;
                textBoxBairro.Text = dadosEndereco.Bairro;
                textBoxLogradouro.Text = dadosEndereco.Logradouro;
                
            }
        }
    }
}
