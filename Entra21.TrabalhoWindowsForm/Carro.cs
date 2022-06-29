using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TrabalhoWindowsForm
{
    internal class Carro
    {
        public int Codigo;
        public Pessoa Proprietario;
        public Concessionaria Loja;

        public EnumCategoria Categoria;
        public string Renavam;
        public string Placa;
        public DateTime AnoFabricacao;
        public DateTime AnoModelo;
        public string LocalizacaoVeiculo;
        public bool LicenciamentoEmDia;
        public bool LincenciamentoEmAtraso;
        public bool TravaEletrica;
        public bool VidrosEletricos;
        public bool DirecaoEletrica;
        public bool DirecaoHidraulica;
        public bool CambioAutomatico;
        public bool BancosEmCouro;
        public bool ArCondicionado;
        public bool ComputadorDeBordo;
        public bool CombustivelAlcool;
        public bool CombustivelGasolina;
        public bool CombustivelDiesel;
        public bool CombustivelFlex;  
    }
}
