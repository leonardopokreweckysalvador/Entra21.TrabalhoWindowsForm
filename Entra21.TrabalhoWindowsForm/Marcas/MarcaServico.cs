using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TrabalhoWindowsForm
{
    //William Lima de Jesus
    internal class MarcaServico
    {
        private string arquivoLocal = "marca.Json";

        private List<Marca> marcas;

        public MarcaServico()
        {
            marcas = new List<Marca>();

            LerArquivo();
        }

        public void LerArquivo()
        {
            if (File.Exists(arquivoLocal) == false)
                return;

            var marcaEmJson = File.ReadAllText(arquivoLocal);
            marcas = JsonConvert.DeserializeObject<List<Marca>>(marcaEmJson);
        }

        public void Adicionar(Marca adicionarMarca)
        {
            marcas.Add(adicionarMarca);

            SalvarArquivo();
        }

        public void Apagar(Marca apagarMarca)
        {
            for (var i = 0; i < marcas.Count; i++)
            {
                var marca = marcas[i];
                if (marca.Codigo == apagarMarca.Codigo)
                {
                    marcas.Remove(apagarMarca);

                    SalvarArquivo();
                    return;
                }
            }
        }
        public void Editar(Marca editarMarca)
        {
            for (var i = 0; i < marcas.Count; i++)
            {
                var marca = marcas[i];

                if (marca.Codigo == editarMarca.Codigo)
                {
                    marca.Nome = editarMarca.Nome;
                    marca.AnoFundacao = editarMarca.AnoFundacao;
                    marca.Grupo = editarMarca.Grupo;
                    marca.Pais = editarMarca.Pais;

                    SalvarArquivo();
                    return;
                }
            }
        }
        public void SalvarArquivo()
        {
            var marcaEmJson = JsonConvert.SerializeObject(marcas);
            File.WriteAllText(arquivoLocal, marcaEmJson);
        }

        public List<Marca> ObterTodos()
        {
            return marcas;
        }

        public Marca ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < marcas.Count; i++)
            {
                var marca = marcas[i];
                if (marca.Codigo == codigo)
                    return marca;
            }
            return null;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;
            for (var i = 0; i < marcas.Count; i++)
            {
                var marca = marcas[i];
                if (marca.Codigo > ultimoCodigo)
                    ultimoCodigo = marca.Codigo;
            }
            return ultimoCodigo;
        }
        public Marca ObterPorNomeMarca(string nomeMarca)
        {
            for(var i = 0; i < marcas.Count; i++)
            {
                var marca = marcas[i];
                if (marca.Nome == nomeMarca)
                    return marca;
            }
            return null;
        }
    }
}
