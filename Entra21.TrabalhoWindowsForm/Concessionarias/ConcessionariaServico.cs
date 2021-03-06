using Newtonsoft.Json;

namespace Entra21.TrabalhoWindowsForm
{
    //Leonardo Pokrewecky Salvador
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

        public List<Concessionaria> ObterTodosMostrar(bool abreFinalSemana)
        {
            if (abreFinalSemana == true)
            {
                var concessionariasAbreFinalSemanha = new List<Concessionaria>();
                for (var i = 0; i < concessionarias.Count; i++)
                {
                    var concessionaria = concessionarias[i];
                    if (concessionaria.AbreFinalSemana == true)
                    {
                        concessionariasAbreFinalSemanha.Add(concessionaria);
                    }
                }
                return concessionariasAbreFinalSemanha;
            }

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
            var UltimoCodigo = 0;
            for (var i = 0; i < concessionarias.Count; i++)
            {
                var concessionaria = concessionarias[i];
                UltimoCodigo = concessionaria.Codigo;
            }

            return UltimoCodigo;
        }

        public Concessionaria ObterPorNomeConcessionária(string nomeLoja)
        {
            for (var i = 0; i < concessionarias.Count; i++)
            {
                var concessionaria = concessionarias[i];
                if (concessionaria.Nome == nomeLoja)
                    return concessionaria;
            }
            return null;
        }
    }
}
