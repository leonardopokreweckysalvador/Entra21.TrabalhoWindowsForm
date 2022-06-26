using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TrabalhoWindowsForm
{
    internal class PessoaServico
    {
        private string ArquivoLocal = "pessoas.json";
        private List<Pessoa> pessoas;

        public PessoaServico()
        {
            pessoas = new List<Pessoa>();

            LerArquivo();
        }

        public void Adicionar(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
            SalvarArquivo();
        }

        public void Apagar(Pessoa pessoaApagar)
        {
            for (var i = 0; i < pessoas.Count; i++)
            {
                var pessoa = pessoas[i];
                if (pessoa.Codigo == pessoaApagar.Codigo)
                {
                    pessoas.Remove(pessoa);
                    SalvarArquivo();
                    return;
                }
            }
        }

        public void Editar(Pessoa pessoaEditar)
        {
            for (var i = 0; i < pessoas.Count; i++)
            {
                var pessoa = pessoas[i];
                if (pessoa.Codigo == pessoaEditar.Codigo)
                {
                    pessoa.Nome = pessoaEditar.Nome;
                    pessoa.DataNascimento = pessoaEditar.DataNascimento;
                    pessoa.Endereco = pessoaEditar.Endereco;
                    pessoa.Sexo = pessoaEditar.Sexo;
                    pessoa.Cpf= pessoaEditar.Cpf;
                    pessoa.Rg = pessoaEditar.Rg;
                    SalvarArquivo();
                    return;                       
                }
            }
        }

        public void LerArquivo()
        {
            if (File.Exists(ArquivoLocal) == false)
                return;
            var pessoasEmJson = File.ReadAllText(ArquivoLocal);
            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoasEmJson);

        }

        public void SalvarArquivo()
        {
            var pessoasEmJson = JsonConvert.SerializeObject(pessoas);
            File.WriteAllText(ArquivoLocal, pessoasEmJson);
        }

        public Pessoa ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < pessoas.Count; i++)
            {
                var pessoa = pessoas[i];
                if (pessoa.Codigo == codigo)
                    return pessoa;
            }

            return null;
        }

        public List<Pessoa> ObterTodas()
        {
            return pessoas;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = int.MinValue;
            for (var i = 0; i < pessoas.Count;i++)
            {
                var pessoa = pessoas[i];
                if (pessoa.Codigo > ultimoCodigo)
                    ultimoCodigo = pessoa.Codigo;
            }

            return ultimoCodigo;
        }
    }
}
