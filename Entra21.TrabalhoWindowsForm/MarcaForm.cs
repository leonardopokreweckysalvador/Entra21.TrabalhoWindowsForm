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
    }
}
