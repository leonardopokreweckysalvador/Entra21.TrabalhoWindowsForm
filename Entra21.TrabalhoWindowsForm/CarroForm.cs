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
    public partial class CarroForm : Form
    {
        private CarroServico carroServico;

        public CarroForm()
        {
            InitializeComponent();

            carroServico = new CarroServico();

            PreencherDataGridViewCarro();
        }

        private void PreencherDataGridViewCarro()
        {
            var carros = carroServico.ObterTodos();

            dataGridViewCarroForm.Rows.Clear();

            for (var i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];

                dataGridViewCarroForm.Rows.Add(new object[]
                {
                    carro.Codigo,
                    carro.Proprietario,
                    carro.Loja,
                    carro.Categoria,
                    carro.Renavam,
                    carro.Placa,
                    carro.AnoFabricacao,
                    carro.AnoModelo,

                });
            }
            dataGridViewCarroForm.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var proprietarioVeiculo = textBoxProprietario.Text;
            var localizacaoVeiculo = textBoxLocalizacaoVeiculo.Text;
            var modeloVeiculo = textBoxModeloVeiculo.Text;
            var categoriaVeiculo = comboBoxCategoriaVeiculo.Text;
            var placaVeiculo = maskedTextBoxPlacaVeiculo.Text;
            var renavam = textBoxRenavam.Text;
            var anoFabricacao = Convert.ToDateTime(dateTimePickerAnoFabricacao.Text);
            var anoModelo = Convert.ToDateTime(dateTimePickerAnoModelo.Text);
            var licenciamentoEmDia = radioButtonLicenciamentoEmDia.Checked;
            var licenciamentoEmAtraso = radioButtonLicenciamentoEmAtraso.Checked;
            var travaEletrica = checkBoxTravaEletrica.Checked;
            var vidrosEletricos = checkBoxVidrosEletricos.Checked;
            var direcaoHidraulica = checkBoxDirecaoHidraulica.Checked;
            var direcaoEletrica = checkBoxDirecaoEletrica.Checked;
            var cambioAutomatico = checkBoxCambioAutomatico.Checked;
            var bancosEmCouro = checkBoxBancosEmCouro.Checked;
            var arCondicionado = checkBoxArCondicionado.Checked;
            var computadorDeBordo = checkBoxComputadorDeBordo.Checked;
            var combustivelGasolina = checkBoxCombustivelGasolina.Checked;
            var combustivelDiesel = checkBoxCombustivelDiesel.Checked;
            var combustivelAlcool = checkBoxCombustivelAlcool.Checked;
            var combustivelFlex = checkBoxCombustivelFlex.Checked;

            var informacoesValidar = ValidarInformacoes(proprietarioVeiculo, localizacaoVeiculo, modeloVeiculo, categoriaVeiculo, placaVeiculo, renavam, anoFabricacao, anoModelo, licenciamentoEmDia, licenciamentoEmAtraso, travaEletrica, vidrosEletricos, direcaoEletrica, direcaoHidraulica, cambioAutomatico, bancosEmCouro, arCondicionado, computadorDeBordo, combustivelAlcool, combustivelGasolina, combustivelDiesel, combustivelFlex);

            if (informacoesValidar == false)
                return;

            if (dataGridViewCarroForm.SelectedRows.Count == 0)
            {
                CadastrarCarro(proprietarioVeiculo, localizacaoVeiculo, modeloVeiculo, categoriaVeiculo, placaVeiculo, renavam, anoFabricacao, anoModelo, licenciamentoEmDia, licenciamentoEmAtraso, travaEletrica, vidrosEletricos, direcaoEletrica, direcaoHidraulica, cambioAutomatico, bancosEmCouro, arCondicionado, computadorDeBordo, combustivelAlcool, combustivelGasolina, combustivelDiesel, combustivelFlex);
            }

            PreencherDataGridViewCarro();

            LimparCampos();
        }

        private bool ValidarInformacoes(string proprietarioVeiculo, string localizacaoVeiculo, string modeloVeiculo, string categoriaVeiculo, string placaVeiculo, string renavam, DateTime anoFabricacao, DateTime anoModelo, bool licenciamentoEmDia, bool licenciamentoEmAtraso, bool travaEletrica, bool vidrosEletricos, bool direcaoEletrica, bool direcaoHidraulica, bool cambioAutomatico, bool bancosEmCouro, bool arCondicionado, bool computadorDeBordo, bool combustivelAlcool, bool combustivelGasolina, bool combustivelDiesel, bool combustivelFlex)
        {
            if (proprietarioVeiculo.Trim().Length == 0)
            {
                MessageBox.Show("Digite o nome completo do proprietário!");
                textBoxProprietario.Focus();
                return false;
            }
            else if(proprietarioVeiculo.Trim().Length < 6)
            {
                MessageBox.Show("Digite o nome completo do proprietário!");
                textBoxProprietario.Focus();
                return false;
            }
            if (localizacaoVeiculo.Trim().Length == 0)
            {
                MessageBox.Show("Digite em qual unidade o veículo se encontra!");
                textBoxLocalizacaoVeiculo.Focus();
                return false;
            }
            else if(localizacaoVeiculo.Trim().Length < 5)
            {
                MessageBox.Show("Digite em qual unidade o veículo se encontra!");
                textBoxLocalizacaoVeiculo.Focus();
                return false;
            }
            if (modeloVeiculo.Replace(" ", "").Trim().Length == 0)
            {
                MessageBox.Show("Digite um modelo de veículo válido!");
                textBoxModeloVeiculo.Focus();
                return false;
            }
            else if (modeloVeiculo.Replace(" ", "").Trim().Length < 3)
            {
                MessageBox.Show("Digite um modelo de veículo válido!");
                textBoxModeloVeiculo.Focus();
                return false;
            }
            if (categoriaVeiculo.Length == -1)
            {
                MessageBox.Show("Selecione uma categoria de veículo!");
                comboBoxCategoriaVeiculo.Focus();
                return false;
            }
            if (placaVeiculo.Replace("-", "").Trim().Length == 0)
            {
                MessageBox.Show("Digite uma placa de veículo válida!");
                maskedTextBoxPlacaVeiculo.Focus();
                return false;
            }
            else if (placaVeiculo.Replace("-", "").Trim().Length < 7)
            {
                MessageBox.Show("Digite uma placa de veículo válida!");
            }
            if (renavam.Replace("-", "").Trim().Length == 0)
            {
                MessageBox.Show("Digite um renavam válido!");
            }
            return true; 
        }

        private void LimparCampos()
        {
            textBoxProprietario.Text = string.Empty;
            textBoxLocalizacaoVeiculo.Text = string.Empty;
            textBoxModeloVeiculo.Text = string.Empty;
            comboBoxCategoriaVeiculo.Text = ResetText();
            maskedTextBoxPlacaVeiculo.Text = string.Empty;
            textBoxRenavam.Text = string.Empty;
            dateTimePickerAnoFabricacao.Text = string.Empty;
            dateTimePickerAnoModelo.Text = string.Empty;
            radioButtonLicenciamentoEmAtraso.Checked = false;
            radioButtonLicenciamentoEmDia.Checked = false;
            checkBoxArCondicionado.Checked = false;
            checkBoxBancosEmCouro.Checked = false;
            checkBoxCambioAutomatico.Checked = false;
            checkBoxCombustivelAlcool.Checked = false;
            checkBoxCombustivelDiesel.Checked = false;
            checkBoxCombustivelFlex.Checked = false;
            checkBoxCombustivelGasolina.Checked = false;
            checkBoxComputadorDeBordo.Checked = false;
            checkBoxDirecaoEletrica.Checked = false;
            checkBoxDirecaoHidraulica.Checked = false;
            checkBoxTravaEletrica.Checked = false;
            checkBoxVidrosEletricos.Checked = false;
        }

        private void CadastrarCarro(string proprietarioVeiculo, string localizacaoVeiculo, string modeloVeiculo, string categoriaVeiculo, string placaVeiculo, string renavam, DateTime anoFabricacao, DateTime anoModelo, bool licenciamentoEmDia, bool licenciamentoEmAtraso, bool travaEletrica, bool vidrosEletricos, bool direcaoEletrica, bool direcaoHidraulica, bool cambioAutomatico, bool bancosEmCouro, bool arCondicionado, bool computadorDeBordo, bool combustivelAlcool, bool combustivelGasolina, bool combustivelDiesel, bool combustivelFlex)
        {

        }
    }
}
