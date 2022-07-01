using Newtonsoft.Json;

namespace Entra21.TrabalhoWindowsForm
{
    //Leonardo Pokrewecky Salvador
    internal class EnderecoServico
    {
        private string LocalArquivo = "enderecos.json";
        private List<Endereco> enderecos;

        public EnderecoServico()
        {
            enderecos = new List<Endereco>();

            LerArquivo();
        }

        public void SalvarArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText(LocalArquivo, enderecosEmJson);
        }

        public void Adicionar(Endereco encoder)
        {
            enderecos.Add(encoder);

            SalvarArquivo();
        }

        public void LerArquivo()
        {
            if (File.Exists(LocalArquivo) == false) return;

            var enderecosEmJson = File.ReadAllText(LocalArquivo);
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecosEmJson);

        }

        public void Editar(Endereco enderecoAlterar)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == enderecoAlterar.Codigo)
                {
                    endereco.Cep = enderecoAlterar.Cep;
                    endereco.Estado = enderecoAlterar.Estado;
                    endereco.Cidade = enderecoAlterar.Cidade;
                    endereco.Bairro = enderecoAlterar.Bairro;
                    endereco.Logradouro = enderecoAlterar.Logradouro;
                    endereco.Numero = enderecoAlterar.Numero;
                    endereco.Complemento = enderecoAlterar.Complemento;

                    SalvarArquivo();
                    return;
                }
            }
        }

        public void Apagar(Endereco enderecoApagar)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == enderecoApagar.Codigo)
                {
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == codigo) return endereco;
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];
                if (endereco.Codigo > ultimoCodigo) ultimoCodigo = endereco.Codigo;
            }
            return ultimoCodigo;
        }

        internal Endereco ObterPorLogredouro(string? enderecoLogradouro)
        {

            var localVirgula = enderecoLogradouro.IndexOf(",");
            var logradouro = enderecoLogradouro.Substring(0, localVirgula).Trim();
            var numero = enderecoLogradouro.Substring((localVirgula + 1), enderecoLogradouro.Length - (localVirgula + 1)).Trim();

            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];
                if (endereco.Logradouro == logradouro && endereco.Numero == numero) return endereco;

            }
            return null;
        }
    }
}
