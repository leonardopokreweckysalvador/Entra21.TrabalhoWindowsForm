﻿using System;
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
        }
    }
}
