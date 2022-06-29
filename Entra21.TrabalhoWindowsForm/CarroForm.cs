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

        private void checkBoxTravaEletrica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var proprietarioVeiculo = textBoxProprietario.Text;
            var localizacaoVeiculo = textBoxLocalizacaoVeiculo.Text;
            var modeloVeiculo = textBoxModeloVeiculo.Text;
            var categoriaVeiculo = comboBoxCategoriaVeiculo.Text;
            var placaVeiculo = maskedTextBoxPlacaVeiculo.Text;
            var renavam = textBoxRenavam.Text;
            var anoFabricacao = dateTimePickerAnoFabricacao.Text;
            var anoModelo = dateTimePickerAnoModelo.Text;
            var licenciamentoEmDia = radioButtonLicenciamentoEmDia.Checked;
            var licenciamentoEmAtraso = radioButtonLicenciamentoEmAtraso.Checked;
            var travaEletrica = checkBoxTravaEletrica.Checked;
            var vidrosEletricos = checkBoxVidrosEletricos.Checked;
            var direcaoHidraulica = checkBoxDirecaoHidraulica.Checked;
            var direcaoEletrica = checkBoxDirecaoEletrica.Checked;
            var cambioAutomatico = checkBoxCambioAutomatico.Checked;
            var bancosEmCouro = checkBoxBancosEmCouro;
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

        private void LimparCampos()
        {
            textBoxProprietario.Text = string.Empty;
            textBoxLocalizacaoVeiculo.Text = string.Empty;
            textBoxModeloVeiculo.Text = string.Empty;
            comboBoxCategoriaVeiculo.Text = string.Empty;
            maskedTextBoxPlacaVeiculo.Text = string.Empty;
            textBoxRenavam.Text = string.Empty;
            dateTimePickerAnoFabricacao.Text = string.Empty;
            dateTimePickerAnoModelo.Text = string.Empty;
            radioButtonLicenciamentoEmAtraso.Checked = bool.;
            radioButtonLicenciamentoEmDia.Text = string.Empty;
        }
    }
}
