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

        public void Adcionar()
        {

        }

        public void Apagar()
        {

        }

        public void Editar()
        {

        }

        public void LerArquivo()
        {

        }

        public void SalvarArquivo()
        {

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
            var ultimoCodigo = int.MinValue;
            for (var i = 0; i < statuses.Count; i++)
            {
                var status = statuses[i];
                if (status.Codigo > ultimoCodigo)
                    ultimoCodigo = status.Codigo;
            }

            return ultimoCodigo;
        }

    }
}
