namespace Entra21.TrabalhoWindowsForm
{
    //William Lima de Jesus
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
                    marca.Grupo,
                    marca.Pais,
                    marca.AnoFundacao.ToString("dd/MM/yyyy"),
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
            LimparCampos();
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

        private void LimparCampos()
        {
            textBoxNomeMarca.Text = string.Empty;
            textBoxGrupoProprietarioMarca.Text = string.Empty;
            textBoxPaisDeOrigem.Text = string.Empty;
            dateTimePickerDataDeFundacaoMarca.Value = DateTime.Now;
            radioButtonNao.Checked = false;
            radioButtonSim.Checked = false;
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
            if (dataGridViewMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma marca para editar...");
                return;
            }

            var linhaSelecionada = dataGridViewMarca.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var marca = marcaServico.ObterPorCodigo(codigo);

            textBoxNomeMarca.Text = marca.Nome;
            textBoxGrupoProprietarioMarca.Text = marca.Grupo;
            textBoxPaisDeOrigem.Text = marca.Pais;
            dateTimePickerDataDeFundacaoMarca.Text = Convert.ToString(marca.AnoFundacao);
            radioButtonNao.Checked = marca.ManutecaoImportada;
            radioButtonSim.Checked = marca.ManutecaoNacional;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecionece uma marca para remover.");
                return;
            }

            var confirmarApagar = MessageBox.Show("Tem certeza que deseja apagar essa marca?", "Atenção", MessageBoxButtons.YesNo);

            if (confirmarApagar != DialogResult.Yes)
            {
                MessageBox.Show("A marca não foi removida do sistema!");
                return;
            }

            var linhaSelecionada = dataGridViewMarca.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var marca = marcaServico.ObterPorCodigo(codigo);

            marcaServico.Apagar(marca);
            PreencherDataGridViewMarca();
        }

        private void MarcaForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewMarca();
        }
    }
}
