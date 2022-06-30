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
    public partial class MarcaForm : Form
    {
        private MarcaServico marcaServico;
        public MarcaForm()
        {
            InitializeComponent();

            marcaServico = new MarcaServico();

            PreencherDataGridViewMarca();
        }

        private void PreencherDataGridViewMarca()
        {
            var marcas = marcaServico.ObterTodos();

            dataGridViewMarca.Rows.Clear();

            for (var i = 0; i < marcas.Count; i++)
            {
                var marca = marcas[i];

                dataGridViewMarca.Rows.Add(new object[]
                {
                    marca.Codigo,
                    marca.Nome,
                    marca.AnoFundacao,
                    marca.Grupo,
                    marca.Pais,
                    marca.ManutecaoNacional,
                    marca.ManutecaoImportada
                });
            }
            dataGridViewMarca.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nomeMarca = textBoxNomeMarca.Text;
            var grupoProprietarioMarca = textBoxGrupoProprietarioMarca.Text;
            var paisOrigemMarca = textBoxPaisDeOrigem.Text;
            var dataFundacaoMarca = Convert.ToDateTime(dateTimePickerDataDeFundacaoMarca.Text);
            var manutencaoNacional = radioButtonSim.Checked;
            var manutencaoImportada = radioButtonNao.Checked;

            var informacoesValidar = ValidarInformacoes(nomeMarca, grupoProprietarioMarca, paisOrigemMarca, dataFundacaoMarca, manutencaoNacional, manutencaoImportada);

            if (informacoesValidar == false)
                return;

            if (dataGridViewMarca.SelectedRows.Count == 0)
            {
                CadastrarMarca(nomeMarca, grupoProprietarioMarca, paisOrigemMarca, dataFundacaoMarca, manutencaoNacional, manutencaoImportada);
            }
            else
                EditarMarca(nomeMarca, grupoProprietarioMarca, paisOrigemMarca, dataFundacaoMarca, manutencaoNacional, manutencaoImportada);

            PreencherDataGridViewMarca();
            //LimparCampos();
        }

        private bool ValidarInformacoes(string nomeMarca, string grupoProprietarioMarca, string paisOrigemmarca, DateTime dataFundacaoMarca, bool manutencaoNacional, bool manutencaoImportada)
        {
            if (nomeMarca.Trim().Length ==0)
            {
                MessageBox.Show("Digite um nome de marca válido!");
                textBoxNomeMarca.Focus();
                return false;
            }
            else if (nomeMarca.Trim().Length < 3)
            {
                MessageBox.Show("Digite um nome de marca válido!");
                textBoxNomeMarca.Focus();
                return false;
            }
            if (grupoProprietarioMarca.Trim().Length == 0)
            {
                MessageBox.Show("Digite um Grupo Proprietário de marca válido!");
                textBoxGrupoProprietarioMarca.Focus();
                return false;
            }
            else if (grupoProprietarioMarca.Trim().Length < 2)
            {
                MessageBox.Show("Digite um Grupo Proprietário de marca válido!");
                textBoxGrupoProprietarioMarca.Focus();
                return false;
            }
            if (paisOrigemmarca.Trim().Length == 0)
            {
                MessageBox.Show("Digite um País válido!");
                textBoxPaisDeOrigem.Focus();
                return false;
            }
            else if (paisOrigemmarca.Trim().Length < 4)
            {
                MessageBox.Show("Digite um País válido!");
                textBoxPaisDeOrigem.Focus();
                return false;
            }
            return true;
        }

        private void CadastrarMarca(string nomeMarca, string grupoProprietarioMarca, string paisOrigemMarca, DateTime dataFundacaoMarca, bool manutencaoNacional, bool manutencaoImportada)
        {
            var marca = new Marca();
            marca.Codigo = marcaServico.ObterUltimoCodigo() + 1;
            marca.Nome = nomeMarca;
            marca.Grupo = grupoProprietarioMarca;
            marca.Pais = paisOrigemMarca;
            marca.AnoFundacao = dataFundacaoMarca;
            marca.ManutecaoNacional = manutencaoNacional;
            marca.ManutecaoImportada = manutencaoImportada;

            marcaServico.Adicionar(marca);
        }

        private void EditarMarca(string nomeMarca, string grupoProprietarioMarca, string paisOrigemmarca, DateTime dataFundacaoMarca, bool manutencaoNacional, bool manutencaoImportada)
        {
            var linhaSelecionada = dataGridViewMarca.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var marca = new Marca()
            {
                Codigo = codigoSelecionado,
                Nome = nomeMarca,
                Grupo = grupoProprietarioMarca,
                Pais = paisOrigemmarca,
                AnoFundacao = dataFundacaoMarca,
                ManutecaoNacional = manutencaoNacional,
                ManutecaoImportada = manutencaoImportada
            };
            marcaServico.Editar(marca);
        }
    }
}
