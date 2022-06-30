using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Entra21.TrabalhoWindowsForm
{
    internal class ConcessionariaServico
    {
        private string LocalArquivo = "concessionaria.json";
        private List<Concessionaria> concessionarias;

        public ConcessionariaServico()
        {
            concessionarias = new List<Concessionaria>();

            LerArquivo();
        }

        public void LerArquivo()
        {
            if (File.Exists(LocalArquivo) == false) return;

            var concessionariaEmJson = File.ReadAllText(LocalArquivo);
            concessionarias = JsonConvert.DeserializeObject<List<Concessionaria>>(concessionariaEmJson);
        }

        public void SalvarArquivo()
        {
            var concessionariaEmJson = JsonConvert.SerializeObject(concessionarias);
            File.WriteAllText(LocalArquivo, concessionariaEmJson);
        }

        public void Adicionar(Concessionaria concessionaria)
        {
            concessionarias.Add(concessionaria);

            SalvarArquivo();
        }

        public void Editar(Concessionaria concessionariaEditar)
        {
            for (var i = 0; i < concessionarias.Count; i++)
            {
                var concessionaria = concessionarias[i];

                if (concessionaria.Codigo == concessionariaEditar.Codigo)
                {
                    concessionaria.Nome = concessionariaEditar.Nome;
                    concessionaria.Cnpj = concessionariaEditar.Cnpj;
                    concessionaria.RazaoSocial = concessionariaEditar.RazaoSocial;
                    concessionaria.DataAbertura = concessionariaEditar.DataAbertura;
                    concessionaria.HoraAbre = concessionariaEditar.HoraAbre;
                    concessionaria.HoraFecha = concessionariaEditar.HoraFecha;
                    concessionaria.AbreFinalSemana = concessionariaEditar.AbreFinalSemana;
                    concessionaria.Endereco = concessionariaEditar.Endereco;
                    concessionaria.Proprietario = concessionariaEditar.Proprietario;

                    SalvarArquivo();
                    return;
                }
            }
        }

        public void Apagar(Concessionaria concessionariaApagar)
        {
            for (var i = 0; i < concessionarias.Count; i++)
            {
                var concessionaria = concessionarias[i];
                if (concessionaria.Codigo == concessionariaApagar.Codigo)
                {
                    concessionarias.Remove(concessionariaApagar);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Concessionaria> ObterTodos()
        {
            return concessionarias;
        }

        public Concessionaria ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < concessionarias.Count; i++)
            {
                var concessionaria = concessionarias[i];

                if (concessionaria.Codigo == codigo) return concessionaria;
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            var UltimoCodigo = int.MinValue;
            for (var i = 0; i < concessionarias.Count; i++)
            {
                var concessionaria = concessionarias[i];
                UltimoCodigo = concessionaria.Codigo;
            }

            return UltimoCodigo;
        }
    }
}
