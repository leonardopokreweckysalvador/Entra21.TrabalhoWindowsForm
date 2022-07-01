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
            var concessionarias = concessionariaServico.ObterTodosMostrar(checkBoxApertoFinalSemana.Checked);

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
                        concessionaria.DataAbertura.ToString("dd/MM/yyyy"),
                        concessionaria.HoraAbre.ToString("HH:mm:ss"),
                        concessionaria.HoraFecha.ToString("HH:mm:ss"),
                        concessionaria.AbreFinalSemana,
                        concessionaria.Proprietario.Nome
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

            if (dataGridViewConcessionaria.SelectedRows.Count == 0)
                CadastrarConcessionaria(nome, cnpj, razaoSocial, proprietario, endereco, dataAbertura, horaAbre, horaFecha, abreFinalSemana);
            else
                EditarConcecionaria(nome, cnpj, razaoSocial, proprietario, endereco, dataAbertura, horaAbre, horaFecha, abreFinalSemana);

            preencherDataGridViewConcessionaria();

            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosConcessionaria();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConcessionaria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para remover");

                return;
            }

            var validar = MessageBox.Show("Gostaria realmente de remover esse registro", "Aviso", MessageBoxButtons.OKCancel);

            if (validar == DialogResult.Cancel) return;

           var concessionaria = RetornaConcessionariaSelecionada();

            concessionariaServico.Apagar(concessionaria);

            preencherDataGridViewConcessionaria();
        }

        private void checkBoxApertoFinalSemana_Click(object sender, EventArgs e)
        {
            preencherDataGridViewConcessionaria();

            LimparCampos();
        }

        private Concessionaria RetornaConcessionariaSelecionada()
        {
            var linhaSelecionada = dataGridViewConcessionaria.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var concessionaria = concessionariaServico.ObterPorCodigo(codigo);
            return concessionaria;
        }

        private void ConcessionariaForm_Load(object sender, EventArgs e)
        {
            preencherDataGridViewConcessionaria();
        }

        private void EditarConcecionaria(string nome, string cnpj, string razaoSocial, string proprietario, string endereco, DateTime dataAbertura, DateTime horaAbre, DateTime horaFecha, bool abreFinalSemana)
        {
            var linhaSelecionada = dataGridViewConcessionaria.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var concessionaria = new Concessionaria()
            {
                Codigo = codigoSelecionado,
                Nome = nome,
                Cnpj = cnpj,
                RazaoSocial = razaoSocial,
                Proprietario = pessoaServico.ObterPorNomePessoa(proprietario),
                Endereco = enderecoServico.ObterPorLogredouro(endereco),
                DataAbertura = dataAbertura,
                HoraFecha = horaFecha,
                HoraAbre = horaAbre,
                AbreFinalSemana = abreFinalSemana
            };
            concessionariaServico.Editar(concessionaria);

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

        private bool ValidarDados(string nome, string cnpj, string razaoSocial, object proprietario, object endereco, DateTime dataAbertura, DateTime horaAbre, DateTime horaFecha, bool abreFinalSemana)
        {

            try
            {
                if (nome.Trim().Length < 5)
                {
                    MessageBox.Show("Nome da concessionaria invalido!");

                    textBoxNome.Focus();

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nome da concessionaria invalido ! \n Erro " + ex);

                textBoxNome.Focus();

                return false;
            }

            try
            {
                if (cnpj.Length != 18)
                {
                    MessageBox.Show("CNPJ Invalido ");

                    maskedTextBoxCnpj.Focus();

                    return false;
                }
                if (dataGridViewConcessionaria.SelectedRows.Count == 0)
                {
                    var concessionarias = concessionariaServico.ObterTodos();
                    for (var i = 0; i < concessionarias.Count; i++)
                    {
                        var concessionaria = concessionarias[i];
                        if (concessionaria.Cnpj == cnpj)
                        {
                            MessageBox.Show("CNPJ já é cadastrado");

                            maskedTextBoxCnpj.Focus();

                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CNPJ invalid ! \n Erro " + ex);

                maskedTextBoxCnpj.Focus();

                return false;
            }

            try
            {
                if (razaoSocial.Length < 5)
                {
                    MessageBox.Show("Razão Social Invalido \nNo minimo 5 caracter");

                    textBoxRazaoSocial.Focus();

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Razão Social Invalido ! \n Erro " + ex);

                textBoxRazaoSocial.Focus();

                return false;
            }

            try
            {
                if (proprietario == "")
                {
                    MessageBox.Show("Selecione uma pessoa");

                    comboBoxProprietario.Focus();

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);

                comboBoxProprietario.Focus();

                return false;
            }

            try
            {
                if (endereco == "")
                {
                    MessageBox.Show("Selecione um endereço");

                    comboBoxEndereco.Focus();

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);

                comboBoxEndereco.Focus();

                return false;
            }

            try
            {
                if (dataAbertura > DateTime.Now)
                {
                    MessageBox.Show("Data de abertura, não pode ser além de hoje");

                    dateTimePickerDataAbertura.Focus();

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!!" + ex);

                dateTimePickerDataAbertura.Focus();

                return false;
            }

            try
            {
                if (dateTimePickerHoraAbre == dateTimePickerHoraFecha )
                {
                    MessageBox.Show("Preencha as horas corretamente ");

                    dateTimePickerHoraAbre.Focus();

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!!" + ex);

                dateTimePickerHoraAbre.Focus();

                return false;
            }

            try
            {
                if (dateTimePickerHoraFecha == dateTimePickerHoraAbre)
                {
                    MessageBox.Show("Preencha as horas corretamente ");

                    dateTimePickerHoraFecha.Focus();

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!!" + ex);

                dateTimePickerHoraFecha.Focus();

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

        private void ApresentarDadosConcessionaria()
        {
            if (dataGridViewConcessionaria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para editar");
                return;
            }

            var concessionaria = RetornaConcessionariaSelecionada();

            textBoxNome.Text = concessionaria.Nome;
            maskedTextBoxCnpj.Text = concessionaria.Cnpj;
            textBoxRazaoSocial.Text = concessionaria.RazaoSocial;
            comboBoxProprietario.Text = concessionaria.Proprietario.Nome;
            comboBoxEndereco.Text = concessionaria.Endereco.Logradouro + ", " + concessionaria.Endereco.Numero;
            dateTimePickerDataAbertura.Text = Convert.ToString(concessionaria.DataAbertura);
            dateTimePickerHoraAbre.Text = Convert.ToString(concessionaria.HoraAbre);
            dateTimePickerHoraFecha.Text = Convert.ToString(concessionaria.HoraFecha);
            if (concessionaria.AbreFinalSemana == true)
                radioButtonAbreFinalSemana.Checked = concessionaria.AbreFinalSemana;
            else
                radioButtonNaoAbreFinalSemana.Checked = true;
        }


    }
}
