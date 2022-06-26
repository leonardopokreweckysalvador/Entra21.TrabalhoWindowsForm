using System;

namespace Entra21.TrabalhoWindowsForm
{
    internal class Concessionaria
    {
        public int Codigo;
        public string Nome;
        public Endereco Endereco;
        public string Cnpj;
        public string RazaoSocial;  
        public DateTime DataAbertura;
        public DateTime HoraAbre;
        public DateTime HoraFecha;
        public bool AbreFinalSemana;
        public Pessoa Proprietario;
    }
}
