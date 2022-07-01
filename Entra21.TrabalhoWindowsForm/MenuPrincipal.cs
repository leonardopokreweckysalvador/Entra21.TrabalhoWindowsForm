namespace Entra21.TrabalhoWindowsForm
{
    //William Lima de J. / Gustavo Lemos / Leonardo Pokrewecky Salvador
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonEndereco_Click(object sender, EventArgs e)
        {
            var enderecoForm = new EnderecoForm();
            enderecoForm.ShowDialog();
        }

        private void buttonpPessoa_Click(object sender, EventArgs e)
        {
            var pessoaForm = new PessoaForm();
            pessoaForm.ShowDialog();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            var statusForm = new StatusForm();
            statusForm.ShowDialog();
        }

        private void buttonConcessionaria_Click(object sender, EventArgs e)
        {
            var concessionariaForm = new ConcessionariaForm();
            concessionariaForm.ShowDialog();
        }

        private void buttonCarros_Click(object sender, EventArgs e)
        {
            var carrosForm = new CarroForm();
            carrosForm.ShowDialog();
        }

        private void buttonMarcas_Click(object sender, EventArgs e)
        {
            var marcasForm = new MarcaForm();
            marcasForm.ShowDialog();
        }
    }
}
