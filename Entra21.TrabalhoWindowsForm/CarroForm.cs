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
        private PessoaServico pessoaServico;
        private MarcaServico marcaServico;
        private ConcessionariaServico concessionariaServico;

        public CarroForm()
        {
            InitializeComponent();

            carroServico = new CarroServico();
            pessoaServico = new PessoaServico();
            marcaServico = new MarcaServico();
            concessionariaServico = new ConcessionariaServico();

            PreencherComboBoxComOsNomesPessoas();
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
                    carro.Marca,
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
            var proprietarioVeiculo = Convert.ToString(comboBoxProprietario.SelectedItem);
            var localizacaoVeiculo = Convert.ToString(comboBoxLoja.SelectedItem);
            var modeloVeiculo = textBoxModeloVeiculo.Text;
            var marcaVeiculo = Convert.ToString(comboBoxMarcaVeiculo.SelectedItem);
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

            var informacoesValidar = ValidarInformacoes(proprietarioVeiculo, localizacaoVeiculo, modeloVeiculo, marcaVeiculo, placaVeiculo, renavam, anoFabricacao, anoModelo, licenciamentoEmDia, licenciamentoEmAtraso, travaEletrica, vidrosEletricos, direcaoEletrica, direcaoHidraulica, cambioAutomatico, bancosEmCouro, arCondicionado, computadorDeBordo, combustivelAlcool, combustivelGasolina, combustivelDiesel, combustivelFlex);

            if (informacoesValidar == false)
                return;

            if (dataGridViewCarroForm.SelectedRows.Count == 0)
            {
                CadastrarCarro(proprietarioVeiculo, localizacaoVeiculo, modeloVeiculo, marcaVeiculo, placaVeiculo, renavam, anoFabricacao, anoModelo, licenciamentoEmDia, licenciamentoEmAtraso, travaEletrica, vidrosEletricos, direcaoEletrica, direcaoHidraulica, cambioAutomatico, bancosEmCouro, arCondicionado, computadorDeBordo, combustivelAlcool, combustivelGasolina, combustivelDiesel, combustivelFlex);
            }
            else
                EditarCarro(proprietarioVeiculo, localizacaoVeiculo, modeloVeiculo, marcaVeiculo, placaVeiculo, renavam, anoFabricacao, anoModelo, licenciamentoEmDia, licenciamentoEmAtraso, travaEletrica, vidrosEletricos, direcaoHidraulica, direcaoEletrica, cambioAutomatico, bancosEmCouro, arCondicionado, computadorDeBordo, combustivelAlcool, combustivelGasolina, combustivelDiesel, combustivelFlex);

            PreencherDataGridViewCarro();

            LimparCampos();
        }

        private bool ValidarInformacoes(object proprietarioVeiculo, string localizacaoVeiculo, string modeloVeiculo, string categoriaVeiculo, string placaVeiculo, string renavam, DateTime anoFabricacao, DateTime anoModelo, bool licenciamentoEmDia, bool licenciamentoEmAtraso, bool travaEletrica, bool vidrosEletricos, bool direcaoEletrica, bool direcaoHidraulica, bool cambioAutomatico, bool bancosEmCouro, bool arCondicionado, bool computadorDeBordo, bool combustivelAlcool, bool combustivelGasolina, bool combustivelDiesel, bool combustivelFlex)
        {
            //if (proprietarioVeiculo.Trim().Length == 0)
            //{
            //    MessageBox.Show("Digite o nome completo do proprietário!");
            //    comboBoxProprietario.Focus();
            //    return false;
            //}
            //if (proprietarioVeiculo.Trim().Length < 6)
            //{
            //    MessageBox.Show("Digite o nome completo do proprietário!");
            //    comboBoxProprietario.Focus();
            //    return false;
            //}
            if (localizacaoVeiculo.Trim().Length == 0)
            {
                MessageBox.Show("Digite em qual unidade o veículo se encontra!");
                comboBoxLoja.Focus();
                return false;
            }
            else if(localizacaoVeiculo.Trim().Length < 5)
            {
                MessageBox.Show("Digite em qual unidade o veículo se encontra!");
                comboBoxLoja.Focus();
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
                comboBoxMarcaVeiculo.Focus();
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
                maskedTextBoxPlacaVeiculo.Focus();
                return false;
            }
            if (renavam.Replace("-", "").Trim().Length == 0)
            {
                MessageBox.Show("Digite um renavam válido!");
                textBoxRenavam.Focus();
                return false;
            }
            else if ((renavam.Replace("-", "").Trim().Length < 9))
            {
                MessageBox.Show("Digite um renavam válido!");
                textBoxRenavam.Focus();
                return false;
            }
            return true; 
        }

        private void LimparCampos()
        {
            comboBoxProprietario.ResetText();
            comboBoxLoja.ResetText();
            textBoxModeloVeiculo.Text = string.Empty;
            comboBoxMarcaVeiculo.ResetText(); 
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

        private void CadastrarCarro(string? proprietarioVeiculo, string localizacaoVeiculo, string modeloVeiculo, string? marcaVeiculo, string placaVeiculo, string renavam, DateTime anoFabricacao, DateTime anoModelo, bool licenciamentoEmDia, bool licenciamentoEmAtraso, bool travaEletrica, bool vidrosEletricos, bool direcaoEletrica, bool direcaoHidraulica, bool cambioAutomatico, bool bancosEmCouro, bool arCondicionado, bool computadorDeBordo, bool combustivelAlcool, bool combustivelGasolina, bool combustivelDiesel, bool combustivelFlex)
        {
            var carro = new Carro();
            carro.Codigo = carroServico.ObterUltimoCodigo() + 1;
            carro.Proprietario = pessoaServico.ObterPorNomePessoa(proprietarioVeiculo);
            carro.LocalizacaoVeiculo = concessionariaServico.o;
            carro.ModeloVeiculo = modeloVeiculo;
            carro.Marca = marcaServico.ObterPorNomeMarca(marcaVeiculo);
            carro.Placa = placaVeiculo;
            carro.Renavam = renavam;
            carro.AnoFabricacao = anoFabricacao;
            carro.AnoModelo = anoModelo;
            carro.LicenciamentoEmDia = licenciamentoEmDia;
            carro.LincenciamentoEmAtraso = licenciamentoEmAtraso;
            carro.VidrosEletricos = vidrosEletricos;
            carro.TravaEletrica = travaEletrica;
            carro.DirecaoEletrica = direcaoEletrica;
            carro.DirecaoHidraulica = direcaoHidraulica;
            carro.CambioAutomatico = cambioAutomatico;
            carro.BancosEmCouro = bancosEmCouro;
            carro.ArCondicionado = arCondicionado;
            carro.ComputadorDeBordo = computadorDeBordo;
            carro.CombustivelAlcool = combustivelAlcool;
            carro.CombustivelDiesel = combustivelDiesel;
            carro.CombustivelFlex = combustivelFlex;
            carro.CombustivelGasolina = combustivelGasolina;

            carroServico.Adicionar(carro);
        }

        private void CarroForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewCarro();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosEditar();
        }

        private void ApresentarDadosEditar()
        {
            if (dataGridViewCarroForm.SelectedRows.Count ==0)
            {
                MessageBox.Show("Selecione um carro para editar...");
                return;
            }

            var linhaSelecionada = dataGridViewCarroForm.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var carro = carroServico.ObterPorCodigo(codigo);

            comboBoxProprietario.Text = carro.Proprietario.Nome;
            comboBoxLoja.Text = carro.LocalizacaoVeiculo;
            textBoxModeloVeiculo.Text = carro.ModeloVeiculo;
            comboBoxMarcaVeiculo.Text = carro.Marca.Nome;
            maskedTextBoxPlacaVeiculo.Text = carro.Placa;
            textBoxRenavam.Text = carro.Renavam;
            dateTimePickerAnoFabricacao.Text = Convert.ToString(carro.AnoFabricacao);
            dateTimePickerAnoModelo.Text = Convert.ToString(carro.AnoModelo);
            radioButtonLicenciamentoEmAtraso.Checked = carro.LincenciamentoEmAtraso;
            radioButtonLicenciamentoEmDia.Checked = carro.LicenciamentoEmDia;
            checkBoxArCondicionado.Checked = carro.ArCondicionado;
            checkBoxBancosEmCouro.Checked = carro.BancosEmCouro;
            checkBoxCambioAutomatico.Checked = carro.CambioAutomatico;
            checkBoxCombustivelAlcool.Checked = carro.CombustivelAlcool;
            checkBoxCombustivelDiesel.Checked = carro.CombustivelDiesel;
            checkBoxCombustivelFlex.Checked = carro.CombustivelFlex;
            checkBoxCombustivelGasolina.Checked = carro.CombustivelGasolina;
            checkBoxComputadorDeBordo.Checked = carro.ComputadorDeBordo;
            checkBoxDirecaoEletrica.Checked = carro.DirecaoEletrica;
            checkBoxDirecaoHidraulica.Checked = carro.DirecaoHidraulica;
            checkBoxTravaEletrica.Checked = carro.TravaEletrica;
            checkBoxVidrosEletricos.Checked = carro.VidrosEletricos;
        }
        private void EditarCarro(string? proprietarioVeiculo, string localizacaoVeiculo, string modeloVeiculo, string? marcaVeiculo, string placaVeiculo, string renavam, DateTime anoFabricacao, DateTime anoModelo, bool licenciamentoEmDia, bool licenciamentoEmAtraso, bool travaEletrica, bool vidrosEletricos, bool direcaoEletrica, bool direcaoHidraulica, bool cambioAutomatico, bool bancosEmCouro, bool arCondicionado, bool computadorDeBordo, bool combustivelAlcool, bool combustivelGasolina, bool combustivelDiesel, bool combustivelFlex)
        {
            var linhaSelecionada = dataGridViewCarroForm.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var carro = new Carro()
            {
                Codigo = codigoSelecionado,
                Proprietario = pessoaServico.ObterPorNomePessoa(proprietarioVeiculo),
                LocalizacaoVeiculo = localizacaoVeiculo,
                ModeloVeiculo = modeloVeiculo,
                Marca = marcaServico.ObterPorNomeMarca(marcaVeiculo),
                Placa = placaVeiculo,
                Renavam = renavam,
                AnoFabricacao = anoFabricacao,
                AnoModelo = anoModelo,
                LicenciamentoEmDia = licenciamentoEmDia,
                LincenciamentoEmAtraso = licenciamentoEmAtraso,
                TravaEletrica = travaEletrica,
                VidrosEletricos = vidrosEletricos,
                DirecaoEletrica = direcaoEletrica,
                DirecaoHidraulica = direcaoHidraulica,
                CambioAutomatico = cambioAutomatico,
                BancosEmCouro = bancosEmCouro,
                ArCondicionado = arCondicionado,
                ComputadorDeBordo = computadorDeBordo,
                CombustivelAlcool = combustivelAlcool,
                CombustivelDiesel = combustivelDiesel,
                CombustivelGasolina = combustivelGasolina,
                CombustivelFlex = combustivelFlex
            };
            carroServico.Editar(carro);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarroForm.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um carro para remover.");
                return;
            }

            var confirmarApagar = MessageBox.Show("Tem certeza que deseja apagar esse carro?", "Atenção", MessageBoxButtons.YesNo);

            if (confirmarApagar != DialogResult.Yes)
            {
                MessageBox.Show("O carro não foi removido do sistema!");
                return;
            }

            var linhaSelecionada = dataGridViewCarroForm.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var carro = carroServico.ObterPorCodigo(codigo);

            carroServico.Apagar(carro);
            PreencherDataGridViewCarro();
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
    }
}
