using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TrabalhoWindowsForm
{
    internal class StatusServico
    {
        private string ArquivoLocal = "status.json";
        private List<Status> statuses;
        
        public StatusServico()
        {
            statuses = new List<Status>();
            LerArquivo();
        }

        public void Adcionar(Status status)
        {
            statuses.Add(status);
            SalvarArquivo();
        }

        public void Apagar(int codigo)
        {
            for (var i = 0; i < statuses.Count; i++)
            {
                var status = statuses[i];
                if (status.Codigo == codigo)
                {
                    statuses.Remove(status);
                    SalvarArquivo();
                    return;
                }
            }
        }

        public void Editar(Status statusEditar)
        {
            var status = ObterPorCodigo(statusEditar.Codigo);
            status.DataCadastro = statusEditar.DataCadastro;
            status.Pessoa = statusEditar.Pessoa;
            status.Profissao = statusEditar.Profissao;
            status.EmpresaTrabalho = statusEditar.EmpresaTrabalho;
            status.Salario = statusEditar.Salario;
            status.NomeLimpo = statusEditar.NomeLimpo;
            status.LimiteFinanceiro = statusEditar.LimiteFinanceiro;
            status.Endereco = statusEditar.Endereco;
            SalvarArquivo();
        }

        public void LerArquivo()
        {
            if (File.Exists(ArquivoLocal) == false)
                return;
            var statusesEmJson = File.ReadAllText(ArquivoLocal);
            statuses = JsonConvert.DeserializeObject<List<Status>>(statusesEmJson);
        }

        public void SalvarArquivo()
        {
            var statusesEmJson = JsonConvert.SerializeObject(statuses);
            File.WriteAllText(ArquivoLocal, statusesEmJson);
        }

        public Status ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < statuses.Count; i++)
            {
                var status = statuses[i];
                if (status.Codigo == codigo)
                    return status;
            }

            return null;
        }

        public List<Status> ObterTodos()
        {
            return statuses;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;
            for (var i = 0; i < statuses.Count; i++)
            {
                var status = statuses[i];
                ultimoCodigo = status.Codigo;
            }

            return ultimoCodigo;
        }
    }
}
