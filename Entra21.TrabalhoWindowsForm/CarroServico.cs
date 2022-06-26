using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TrabalhoWindowsForm
{
    internal class CarroServico
    {
        private string arquivoLocal = "carro.Json";

        private List<Carro> carros;

        public CarroServico()
        {
            carros = new List<Carro>();

            LerArquivo();
        }

        public void LerArquivo()
        {
            if (File.Exists(arquivoLocal) == false)
                return;

            var carroEmJson = File.ReadAllText(arquivoLocal);
            carros = JsonConvert.DeserializeObject<List<Carro>>(carroEmJson);
        }

        public void Adicionar(Carro adicionarCarro)
        {
            carros.Add(adicionarCarro);

            SalvarArquivo();
        }

        public void Apagar(Carro apagarCarro)
        {
            for (var i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];
                if(carro.Codigo == apagarCarro.Codigo)
                {
                    carros.Remove(apagarCarro);

                    SalvarArquivo();
                    return;
                }
            }
        }
        public void Editar(Carro editarCarro)
        {
            for (var i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];

                if (carro.Codigo == editarCarro.Codigo)
                {
                    carro.Proprietario = editarCarro.Proprietario;
                    carro.Loja = editarCarro.Loja;
                    carro.Categoria = editarCarro.Categoria;
                    carro.Renavam = editarCarro.Renavam;
                    carro.Placa = editarCarro.Placa;
                    carro.AnoFabricacao = editarCarro.AnoFabricacao;
                    carro.AnoModelo = editarCarro.AnoModelo;

                    SalvarArquivo();
                    return;
                }
            }
        }

    }
}
