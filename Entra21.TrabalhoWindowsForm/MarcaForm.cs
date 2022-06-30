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

            //var informacoesValidar = ValidarInformacoes(nomeMarca, grupoProprietarioMarca, paisOrigemMarca, dataFundacaoMarca, manutencaoNacional, manutencaoImportada);

            //if (informacoesValidar == false)
                return;

            if (dataGridViewMarca.SelectedRows.Count == 0)
            {
                //CadastrarMarca(nomeMarca, grupoProprietarioMarca, paisOrigemMarca, dataFundacaoMarca, manutencaoNacional, manutencaoImportada);
            }
            else
               // EditarMarca(nomeMarca, grupoProprietarioMarca, paisOrigemMarca, dataFundacaoMarca, manutencaoNacional, manutencaoImportada);

            PreencherDataGridViewMarca();
            //LimparCampos();
        }
    }
}
